using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryAybar.ERP2.CLS;

namespace pryAybar.ERP2
{
    public partial class frmPrincipal : Form
    {
        private int currentUserId;
        private string currentUserNombre;
        private string currentUserPerfil;

        // DataTables for grids in Add/Edit user
        private DataTable dtAgRedes;
        private DataTable dtAgDomicilios;
        private DataTable dtEdRedes;
        private DataTable dtEdDomicilios;

        public frmPrincipal(int idUsuario, string nombreCompleto, string perfil)
        {
            InitializeComponent();
            currentUserId = idUsuario;
            currentUserNombre = nombreCompleto;
            currentUserPerfil = perfil;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // 1. Session Details
            lblSessionUser.Text = currentUserNombre;
            lblSessionPerfil.Text = "Rol: " + currentUserPerfil;

            // 2. Control Access to Auditoria (Visible only for Admin)
            btnNavAuditoria.Visible = (currentUserPerfil.ToLower() == "admin");

            // 3. Initialize Grid Sources for Add User
            dtAgRedes = new DataTable();
            dtAgRedes.Columns.Add("Red Social");
            dtAgRedes.Columns.Add("Usuario");
            dgvAgRedes.DataSource = dtAgRedes;

            dtAgDomicilios = new DataTable();
            dtAgDomicilios.Columns.Add("Nombre");
            dtAgDomicilios.Columns.Add("Numeracion");
            dtAgDomicilios.Columns.Add("Tipo");
            dtAgDomicilios.Columns.Add("Link Maps");
            dgvAgDomicilios.DataSource = dtAgDomicilios;

            // Initialize Grid Sources for Edit User
            dtEdRedes = new DataTable();
            dtEdRedes.Columns.Add("Red Social");
            dtEdRedes.Columns.Add("Usuario");
            dgvEdRedes.DataSource = dtEdRedes;

            dtEdDomicilios = new DataTable();
            dtEdDomicilios.Columns.Add("Nombre");
            dtEdDomicilios.Columns.Add("Numeracion");
            dtEdDomicilios.Columns.Add("Tipo");
            dtEdDomicilios.Columns.Add("Link Maps");
            dgvEdDomicilios.DataSource = dtEdDomicilios;

            // 4. Fill Combo static items
            string[] socialNets = { "Instagram", "Facebook", "X/Twitter", "LinkedIn", "Otro" };
            cmbAgRedSocial.Items.AddRange(socialNets);
            cmbAgRedSocial.SelectedIndex = 0;
            cmbEdRedSocial.Items.AddRange(socialNets);
            cmbEdRedSocial.SelectedIndex = 0;

            string[] domTypes = { "Residencia", "Legal", "Temporal" };
            cmbAgDomTipo.Items.AddRange(domTypes);
            cmbAgDomTipo.SelectedIndex = 0;
            cmbEdDomTipo.Items.AddRange(domTypes);
            cmbEdDomTipo.SelectedIndex = 0;

            // Load Combos from Access DB
            CargarCombosBD();

            // 5. Default Navigation tab
            ShowPanel(pnlAgregar);

            // 6. Check database connection status initially
            TestDatabaseConnection();
        }

        private void CargarCombosBD()
        {
            try
            {
                // Perfiles
                DataTable dtP = csMetodos.ObtenerPerfiles();
                cmbAgPerfil.DisplayMember = "Nombre";
                cmbAgPerfil.ValueMember = "Id_Perfil";
                cmbAgPerfil.DataSource = dtP;

                DataTable dtP2 = dtP.Copy();
                cmbEdPerfil.DisplayMember = "Nombre";
                cmbEdPerfil.ValueMember = "Id_Perfil";
                cmbEdPerfil.DataSource = dtP2;

                // Provincias
                DataTable dtProv = csMetodos.ObtenerProvincias();
                cmbAgProvincia.DisplayMember = "Provincias";
                cmbAgProvincia.ValueMember = "Id-Provincias";
                cmbAgProvincia.DataSource = dtProv;

                // Localidades
                DataTable dtLoc = csMetodos.ObtenerLocalidades();
                cmbAgLocalidad.DisplayMember = "Localidad";
                cmbAgLocalidad.ValueMember = "Id-Localidad";
                cmbAgLocalidad.DataSource = dtLoc;

                // Edit Selection ComboBox
                CargarComboUsuariosEdicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales de la BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboUsuariosEdicion()
        {
            DataTable dtUsers = csMetodos.ObtenerUsuariosActivos();
            cmbEdSeleccionar.DisplayMember = "Display";
            cmbEdSeleccionar.ValueMember = "Id_Usuario";
            cmbEdSeleccionar.DataSource = dtUsers;
            cmbEdSeleccionar.SelectedIndex = -1;
            LimpiarCamposEdicion();
        }

        private void ShowPanel(Panel activePanel)
        {
            pnlAgregar.Visible = (activePanel == pnlAgregar);
            pnlEditar.Visible = (activePanel == pnlEditar);
            pnlAuditoria.Visible = (activePanel == pnlAuditoria);
            pnlEstadoConex.Visible = (activePanel == pnlEstadoConex);

            // Highlight Active Nav Button
            btnNavAgregar.BackColor = (activePanel == pnlAgregar) ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavEditar.BackColor = (activePanel == pnlEditar) ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavAuditoria.BackColor = (activePanel == pnlAuditoria) ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavEstadoConex.BackColor = (activePanel == pnlEstadoConex) ? Color.FromArgb(37, 74, 123) : Color.Transparent;

            // Set Header Text
            if (activePanel == pnlAgregar) lblHeaderTitle.Text = "AGREGAR NUEVO USUARIO";
            else if (activePanel == pnlEditar) lblHeaderTitle.Text = "EDITAR USUARIO EXISTENTE";
            else if (activePanel == pnlAuditoria) lblHeaderTitle.Text = "AUDITORÍA DE INICIOS DE SESIÓN";
            else if (activePanel == pnlEstadoConex) lblHeaderTitle.Text = "ESTADO DE CONEXIÓN A LA BASE DE DATOS";
        }

        private void TestDatabaseConnection()
        {
            lblConStatus.Text = "Estado: Verificando...";
            pnlConStatusIndicator.BackColor = Color.Gray;
            Application.DoEvents();

            string msg;
            bool isConnected = csConexion.TestConnection(out msg);

            lblConStatus.Text = isConnected ? "Estado: Conectado" : "Estado: Desconectado";
            pnlConStatusIndicator.BackColor = isConnected ? Color.LimeGreen : Color.Crimson;
            lblConDetails.Text = $"Última comprobación: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                                $"Detalle: {msg}\n" +
                                $"Base de datos: Access (Aybar1.accdb)\n" +
                                $"Proveedor: Microsoft.ACE.OLEDB.12.0";
        }

        // NAVIGATION BUTTONS
        private void btnNavAgregar_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAgregar);
        }

        private void btnNavEditar_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEditar);
            CargarComboUsuariosEdicion();
        }

        private void btnNavAuditoria_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAuditoria);
            CargarAuditoriaGrid();
        }

        private void btnNavEstadoConex_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEstadoConex);
            TestDatabaseConnection();
        }

        private void btnNavCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNavSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // APARTADO 1: AGREGAR USUARIO - REDES SOCIALES
        private void btnAgAddRed_Click(object sender, EventArgs e)
        {
            string red = cmbAgRedSocial.Text;
            string usuario = txtAgRedUser.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor ingrese el usuario o identificador de la red social.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check duplicate
            foreach (DataRow row in dtAgRedes.Rows)
            {
                if (row["Red Social"].ToString() == red && row["Usuario"].ToString() == usuario)
                {
                    MessageBox.Show("Esta red social ya fue agregada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dtAgRedes.Rows.Add(red, usuario);
            txtAgRedUser.Clear();
        }

        private void btnAgRemoveRed_Click(object sender, EventArgs e)
        {
            if (dgvAgRedes.CurrentRow != null)
            {
                dgvAgRedes.Rows.RemoveAt(dgvAgRedes.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // APARTADO 1: AGREGAR USUARIO - DOMICILIOS
        private void btnAgAddDom_Click(object sender, EventArgs e)
        {
            string nombre = txtAgDomNombre.Text.Trim();
            string numero = txtAgDomNumero.Text.Trim();
            string tipo = cmbAgDomTipo.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre de la calle/domicilio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string addressQuery = nombre + (string.IsNullOrEmpty(numero) ? "" : " " + numero);
            string mapsLink = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(addressQuery);

            dtAgDomicilios.Rows.Add(nombre, numero, tipo, mapsLink);

            txtAgDomNombre.Clear();
            txtAgDomNumero.Clear();
            cmbAgDomTipo.SelectedIndex = 0;
        }

        private void btnAgRemoveDom_Click(object sender, EventArgs e)
        {
            if (dgvAgDomicilios.CurrentRow != null)
            {
                dgvAgDomicilios.Rows.RemoveAt(dgvAgDomicilios.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgMaps_Click(object sender, EventArgs e)
        {
            AbrirMapsDesdeGrid(dgvAgDomicilios);
        }

        private void AbrirMapsDesdeGrid(DataGridView dgv)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un domicilio de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string link = dgv.CurrentRow.Cells["Link Maps"].Value.ToString();
            if (string.IsNullOrEmpty(link))
            {
                string nombre = dgv.CurrentRow.Cells["Nombre"].Value.ToString();
                string numero = dgv.CurrentRow.Cells["Numeracion"].Value.ToString();
                link = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(nombre + " " + numero);
            }

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir Google Maps: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // APARTADO 1: AGREGAR USUARIO - GUARDAR
        private void btnAgGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtAgNombre.Text.Trim();
            string apellido = txtAgApellido.Text.Trim();
            string dni = txtAgDNI.Text.Trim();
            string pass = txtAgPassword.Text.Trim();
            string mail = txtAgMail.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Los campos Nombre, Apellido, DNI y Contraseña son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAgPerfil.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un perfil válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPerfil = Convert.ToInt32(cmbAgPerfil.SelectedValue);

            // Construct list of contacts
            List<Tuple<string, string, string>> contactos = new List<Tuple<string, string, string>>();
            
            // Add primary cellphone and email if provided
            string celular = txtAgCelular.Text.Trim();
            if (!string.IsNullOrEmpty(celular) || !string.IsNullOrEmpty(mail))
            {
                contactos.Add(new Tuple<string, string, string>(celular, null, mail));
            }

            // Add social networks as individual contact entries
            foreach (DataRow row in dtAgRedes.Rows)
            {
                string redStr = $"{row["Red Social"]}: {row["Usuario"]}";
                contactos.Add(new Tuple<string, string, string>(null, redStr, null));
            }

            // Construct list of addresses
            List<Tuple<string, string, string, string>> domicilios = new List<Tuple<string, string, string, string>>();
            foreach (DataRow row in dtAgDomicilios.Rows)
            {
                domicilios.Add(new Tuple<string, string, string, string>(
                    row["Nombre"].ToString(),
                    row["Numeracion"].ToString(),
                    row["Tipo"].ToString(),
                    row["Link Maps"].ToString()
                ));
            }

            try
            {
                int newUserId = csMetodos.AgregarUsuario(nombre, apellido, dni, pass, mail, idPerfil, contactos, domicilios);
                MessageBox.Show($"Usuario '{nombre} {apellido}' registrado con éxito con el ID: {newUserId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAgLimpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario en el sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgLimpiar_Click(object sender, EventArgs e)
        {
            txtAgNombre.Clear();
            txtAgApellido.Clear();
            txtAgDNI.Clear();
            txtAgPassword.Clear();
            txtAgMail.Clear();
            txtAgCelular.Clear();
            txtAgRedUser.Clear();
            txtAgDomNombre.Clear();
            txtAgDomNumero.Clear();
            
            if (cmbAgPerfil.Items.Count > 0) cmbAgPerfil.SelectedIndex = 0;
            if (cmbAgProvincia.Items.Count > 0) cmbAgProvincia.SelectedIndex = 0;
            if (cmbAgLocalidad.Items.Count > 0) cmbAgLocalidad.SelectedIndex = 0;
            cmbAgRedSocial.SelectedIndex = 0;
            cmbAgDomTipo.SelectedIndex = 0;

            dtAgRedes.Rows.Clear();
            dtAgDomicilios.Rows.Clear();
        }

        // APARTADO 2: EDITAR USUARIO - SELECCIÓN
        private void cmbEdSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                LimpiarCamposEdicion();
                return;
            }

            int idUsuario;
            if (!int.TryParse(cmbEdSeleccionar.SelectedValue.ToString(), out idUsuario))
            {
                return;
            }

            try
            {
                // 1. Get Details
                DataRow userRow = csMetodos.ObtenerDetalleUsuario(idUsuario);
                if (userRow == null) return;

                lblEdActNomVal.Text = userRow["Nombre"].ToString();
                lblEdActApeVal.Text = userRow["Apellido"].ToString();
                lblEdActDNIVal.Text = userRow["DNI"].ToString();
                lblEdActPassVal.Text = userRow["Contraseña"].ToString();
                lblEdActMailVal.Text = userRow["Mail"].ToString();

                txtEdNombre.Text = userRow["Nombre"].ToString();
                txtEdApellido.Text = userRow["Apellido"].ToString();
                txtEdDNI.Text = userRow["DNI"].ToString();
                txtEdPassword.Text = userRow["Contraseña"].ToString();
                txtEdMail.Text = userRow["Mail"].ToString();

                // Profile
                int idPerfil = csMetodos.ObtenerPerfilUsuario(idUsuario);
                cmbEdPerfil.SelectedValue = idPerfil;

                // Load profiles names
                DataTable dtP = (DataTable)cmbEdPerfil.DataSource;
                if (dtP != null)
                {
                    DataRow[] pRows = dtP.Select($"Id_Perfil = {idPerfil}");
                    lblEdActPerfilVal.Text = pRows.Length > 0 ? pRows[0]["Nombre"].ToString() : "-";
                }

                // 2. Load Contacts
                dtEdRedes.Rows.Clear();
                txtEdCelular.Clear();

                DataTable contactsTable = csMetodos.ObtenerContactosUsuario(idUsuario);
                foreach (DataRow r in contactsTable.Rows)
                {
                    string cel = r["Numero Celular"].ToString();
                    if (!string.IsNullOrEmpty(cel) && string.IsNullOrEmpty(txtEdCelular.Text))
                    {
                        txtEdCelular.Text = cel;
                    }

                    string redStr = r["Redes Sociales"].ToString();
                    if (!string.IsNullOrEmpty(redStr))
                    {
                        string[] parts = redStr.Split(new string[] { ": " }, StringSplitOptions.None);
                        if (parts.Length >= 2)
                        {
                            dtEdRedes.Rows.Add(parts[0], parts[1]);
                        }
                        else
                        {
                            dtEdRedes.Rows.Add("Otro", redStr);
                        }
                    }
                }

                // 3. Load Domicilios
                dtEdDomicilios.Rows.Clear();
                DataTable addressesTable = csMetodos.ObtenerDomiciliosUsuario(idUsuario);
                foreach (DataRow r in addressesTable.Rows)
                {
                    dtEdDomicilios.Rows.Add(
                        r["Nombre"].ToString(),
                        r["Numeracion"].ToString(),
                        r["Tipo"].ToString(),
                        r["Link Maps"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposEdicion()
        {
            lblEdActNomVal.Text = "-";
            lblEdActApeVal.Text = "-";
            lblEdActDNIVal.Text = "-";
            lblEdActPassVal.Text = "-";
            lblEdActMailVal.Text = "-";
            lblEdActPerfilVal.Text = "-";

            txtEdNombre.Clear();
            txtEdApellido.Clear();
            txtEdDNI.Clear();
            txtEdPassword.Clear();
            txtEdMail.Clear();
            txtEdCelular.Clear();
            txtEdRedUser.Clear();
            txtEdDomNombre.Clear();
            txtEdDomNumero.Clear();

            if (cmbEdPerfil.Items.Count > 0) cmbEdPerfil.SelectedIndex = -1;
            cmbEdRedSocial.SelectedIndex = 0;
            cmbEdDomTipo.SelectedIndex = 0;

            dtEdRedes.Rows.Clear();
            dtEdDomicilios.Rows.Clear();
        }

        // APARTADO 2: EDITAR USUARIO - REDES
        private void btnEdAddRed_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1) return;
            string red = cmbEdRedSocial.Text;
            string user = txtEdRedUser.Text.Trim();

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Ingrese el usuario de la red social.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtEdRedes.Rows.Add(red, user);
            txtEdRedUser.Clear();
        }

        private void btnEdRemoveRed_Click(object sender, EventArgs e)
        {
            if (dgvEdRedes.CurrentRow != null)
            {
                dgvEdRedes.Rows.RemoveAt(dgvEdRedes.CurrentRow.Index);
            }
        }

        // APARTADO 2: EDITAR USUARIO - DOMICILIOS
        private void btnEdAddDom_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1) return;
            string nombre = txtEdDomNombre.Text.Trim();
            string numero = txtEdDomNumero.Text.Trim();
            string tipo = cmbEdDomTipo.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre de la calle/domicilio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mapsLink = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(nombre + " " + numero);
            dtEdDomicilios.Rows.Add(nombre, numero, tipo, mapsLink);

            txtEdDomNombre.Clear();
            txtEdDomNumero.Clear();
        }

        private void btnEdRemoveDom_Click(object sender, EventArgs e)
        {
            if (dgvEdDomicilios.CurrentRow != null)
            {
                dgvEdDomicilios.Rows.RemoveAt(dgvEdDomicilios.CurrentRow.Index);
            }
        }

        private void btnEdMaps_Click(object sender, EventArgs e)
        {
            AbrirMapsDesdeGrid(dgvEdDomicilios);
        }

        // APARTADO 2: EDITAR USUARIO - GUARDAR CAMBIOS
        private void btnEdGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un usuario para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(cmbEdSeleccionar.SelectedValue);
            string nombre = txtEdNombre.Text.Trim();
            string apellido = txtEdApellido.Text.Trim();
            string dni = txtEdDNI.Text.Trim();
            string pass = txtEdPassword.Text.Trim();
            string mail = txtEdMail.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Los campos Nombre, Apellido, DNI y Contraseña son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPerfil = Convert.ToInt32(cmbEdPerfil.SelectedValue);

            // Construct contacts
            List<Tuple<string, string, string>> contactos = new List<Tuple<string, string, string>>();
            string celular = txtEdCelular.Text.Trim();
            if (!string.IsNullOrEmpty(celular) || !string.IsNullOrEmpty(mail))
            {
                contactos.Add(new Tuple<string, string, string>(celular, null, mail));
            }

            foreach (DataRow row in dtEdRedes.Rows)
            {
                string redStr = $"{row["Red Social"]}: {row["Usuario"]}";
                contactos.Add(new Tuple<string, string, string>(null, redStr, null));
            }

            // Construct addresses
            List<Tuple<string, string, string, string>> domicilios = new List<Tuple<string, string, string, string>>();
            foreach (DataRow row in dtEdDomicilios.Rows)
            {
                domicilios.Add(new Tuple<string, string, string, string>(
                    row["Nombre"].ToString(),
                    row["Numeracion"].ToString(),
                    row["Tipo"].ToString(),
                    row["Link Maps"].ToString()
                ));
            }

            try
            {
                if (csMetodos.ActualizarUsuario(idUsuario, nombre, apellido, dni, pass, mail, idPerfil, contactos, domicilios))
                {
                    MessageBox.Show("Los datos del usuario fueron actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarComboUsuariosEdicion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // APARTADO 2: EDITAR USUARIO - DAR DE BAJA (DESACTIVAR)
        private void btnEdBaja_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un usuario para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(cmbEdSeleccionar.SelectedValue);
            string userDisplay = cmbEdSeleccionar.Text;

            DialogResult confirm = MessageBox.Show($"¿Está seguro de que desea dar de baja al usuario '{userDisplay}'?\nPasará a estar inactivo en el sistema.", 
                "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (csMetodos.DarDeBajaUsuario(idUsuario))
                    {
                        MessageBox.Show("El usuario ha sido dado de baja (inactivo) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarComboUsuariosEdicion();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo dar de baja al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la baja del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // APARTADO 3: AUDITORÍA
        private void CargarAuditoriaGrid()
        {
            try
            {
                DataTable dtAud = csMetodos.ObtenerAuditoria();
                dgvAuditoria.DataSource = dtAud;

                // Estilizar columnas
                if (dgvAuditoria.Columns.Count > 0)
                {
                    dgvAuditoria.Columns["Id_Auditoria"].HeaderText = "ID";
                    dgvAuditoria.Columns["Id_Auditoria"].Width = 60;
                    dgvAuditoria.Columns["Fecha"].HeaderText = "Fecha";
                    dgvAuditoria.Columns["Fecha"].Width = 100;
                    dgvAuditoria.Columns["Hora"].HeaderText = "Hora";
                    dgvAuditoria.Columns["Hora"].Width = 100;
                    dgvAuditoria.Columns["Usuario"].HeaderText = "Usuario Ingresado";
                    dgvAuditoria.Columns["Usuario"].Width = 150;
                    dgvAuditoria.Columns["Detalle"].HeaderText = "Detalle del Intento";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAudRefrescar_Click(object sender, EventArgs e)
        {
            CargarAuditoriaGrid();
        }

        // APARTADO 4: ESTADO DE CONEXIÓN
        private void btnConReconectar_Click(object sender, EventArgs e)
        {
            TestDatabaseConnection();
        }

        private void pnlConStatusIndicator_Paint(object sender, PaintEventArgs e)
        {
            // Draw a circular status indicator
            int circleSize = 80;
            int x = (pnlConStatusIndicator.Width - circleSize) / 2;
            int y = (pnlConStatusIndicator.Height - circleSize) / 2;

            // Determine color based on connection status
            Color indicatorColor = System.Drawing.Color.Gray; // Default: verificando

            if (lblConStatus.Text.Contains("Conectado"))
            {
                indicatorColor = System.Drawing.Color.LimeGreen;
            }
            else if (lblConStatus.Text.Contains("Desconectado"))
            {
                indicatorColor = System.Drawing.Color.Red;
            }

            // Draw circle
            using (Brush brush = new SolidBrush(indicatorColor))
            {
                e.Graphics.FillEllipse(brush, x, y, circleSize, circleSize);
            }

            // Draw border
            using (Pen pen = new Pen(System.Drawing.Color.DarkGray, 2))
            {
                e.Graphics.DrawEllipse(pen, x, y, circleSize, circleSize);
            }
        }
    }
}
