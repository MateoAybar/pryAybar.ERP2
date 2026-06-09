using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
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

        // ErrorProvider for field validation
        private ErrorProvider errorProvider = new ErrorProvider();
        private ToolTip toolTip = new ToolTip();

        // Color constants
        private static readonly Color ColorError    = Color.FromArgb(255, 220, 220);
        private static readonly Color ColorNormal   = Color.White;
        private static readonly Color ColorConOk    = Color.FromArgb(39, 174, 96);
        private static readonly Color ColorConErr   = Color.FromArgb(192, 57, 43);
        private static readonly Color ColorConCheck = Color.FromArgb(127, 140, 141);

        public frmPrincipal(int idUsuario, string nombreCompleto, string perfil)
        {
            InitializeComponent();
            currentUserId    = idUsuario;
            currentUserNombre = nombreCompleto;
            currentUserPerfil = perfil;
            this.MinimizeBox = true;  // Corrección: ventana se puede minimizar
            this.MaximizeBox = true;
            this.KeyPreview  = true;  // Permite atajos de teclado globales
        }

        // ─── FORM LOAD ───────────────────────────────────────────────────────────
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // 1. Session Details
            lblSessionUser.Text   = currentUserNombre;
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

            // Corrección: CMB Gmail con tipos de correo precargados
            string[] gmailDomains = { "@gmail.com", "@hotmail.com", "@outlook.com", "@yahoo.com", "@live.com" };
            cmbAgMailDominio.Items.AddRange(gmailDomains);
            cmbAgMailDominio.SelectedIndex = 0;
            cmbEdMailDominio.Items.AddRange(gmailDomains);
            cmbEdMailDominio.SelectedIndex = 0;

            // Load Combos from Access DB
            CargarCombosBD();

            // Corrección: CMB localidad deshabilitado hasta que se elija Córdoba
            cmbAgLocalidad.Enabled = false;
            cmbAgProvincia.SelectedIndexChanged += CmbAgProvincia_SelectedIndexChanged;

            // 5. Default Navigation tab
            ShowPanel(pnlAgregar);

            // 6. Apply grid styles
            AplicarEstiloGrilla(dgvAuditoria);
            AplicarEstiloGrilla(dgvAgRedes);
            AplicarEstiloGrilla(dgvAgDomicilios);
            AplicarEstiloGrilla(dgvEdRedes);
            AplicarEstiloGrilla(dgvEdDomicilios);

            // 7. Check database connection status initially
            TestDatabaseConnection();

            // 8. Enter key on fields triggers save
            ConectarTeclaEnterEnCampos();
        }

        // ─── KEYBOARD SHORTCUTS ──────────────────────────────────────────────────
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Ctrl+S = Guardar según panel activo
                if (pnlAgregar.Visible) btnAgGuardar_Click(null, null);
                else if (pnlEditar.Visible) btnEdGuardar_Click(null, null);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (pnlAuditoria.Visible) CargarAuditoriaGrid();
                else if (pnlEstadoConex.Visible) TestDatabaseConnection();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (pnlAgregar.Visible) btnAgLimpiar_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void ConectarTeclaEnterEnCampos()
        {
            // Permitir Enter en los campos principales para avanzar / guardar
            Control[] camposAg = { txtAgNombre, txtAgApellido, txtAgDNI, txtAgPassword, txtAgMailLocal };
            foreach (var c in camposAg)
                c.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { SelectNextControl((Control)s, true, true, true, true); e.SuppressKeyPress = true; } };

            Control[] camposEd = { txtEdNombre, txtEdApellido, txtEdDNI, txtEdPassword, txtEdMailLocal };
            foreach (var c in camposEd)
                c.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { SelectNextControl((Control)s, true, true, true, true); e.SuppressKeyPress = true; } };
        }

        // ─── GRID STYLING ────────────────────────────────────────────────────────
        private void AplicarEstiloGrilla(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles         = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor   = Color.FromArgb(27, 54, 93);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor   = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font        = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment   = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight                       = 32;

            dgv.DefaultCellStyle.BackColor     = Color.White;
            dgv.DefaultCellStyle.ForeColor     = Color.FromArgb(33, 33, 33);
            dgv.DefaultCellStyle.Font          = new Font("Segoe UI", 9f);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(27, 54, 93);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 252);

            dgv.GridColor        = Color.FromArgb(220, 230, 240);
            dgv.BorderStyle      = BorderStyle.None;
            dgv.CellBorderStyle  = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode    = DataGridViewSelectionMode.FullRowSelect;

            dgv.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].Selected)
                    e.CellStyle.BackColor = Color.FromArgb(200, 220, 245);
            };
        }

        // ─── PROVINCIA / LOCALIDAD LOCK ─────────────────────────────────────────
        private void CmbAgProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAgProvincia.SelectedItem == null) { cmbAgLocalidad.Enabled = false; return; }
            string prov = cmbAgProvincia.Text.Trim().ToLower();
            // Corrección: localidad solo se desbloquea si la provincia es Córdoba
            cmbAgLocalidad.Enabled = prov.Contains("c") && prov.Contains("rdoba");
            if (!cmbAgLocalidad.Enabled) cmbAgLocalidad.SelectedIndex = -1;
        }

        // ─── DB COMBOS ──────────────────────────────────────────────────────────
        private void CargarCombosBD()
        {
            try
            {
                DataTable dtP = csMetodos.ObtenerPerfiles();
                cmbAgPerfil.DisplayMember = "Nombre";
                cmbAgPerfil.ValueMember   = "Id_Perfil";
                cmbAgPerfil.DataSource    = dtP;

                DataTable dtP2 = dtP.Copy();
                cmbEdPerfil.DisplayMember = "Nombre";
                cmbEdPerfil.ValueMember   = "Id_Perfil";
                cmbEdPerfil.DataSource    = dtP2;

                DataTable dtProv = csMetodos.ObtenerProvincias();
                cmbAgProvincia.DisplayMember = "Provincias";
                cmbAgProvincia.ValueMember   = "Id-Provincias";
                cmbAgProvincia.DataSource    = dtProv;

                DataTable dtLoc = csMetodos.ObtenerLocalidades();
                cmbAgLocalidad.DisplayMember = "Localidad";
                cmbAgLocalidad.ValueMember   = "Id-Localidad";
                cmbAgLocalidad.DataSource    = dtLoc;

                CargarComboUsuariosEdicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales de la BD: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboUsuariosEdicion()
        {
            // Corrección: combo con búsqueda por nombre (DropDown en lugar de DropDownList)
            cmbEdSeleccionar.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable dtUsers = csMetodos.ObtenerUsuariosActivos();
            cmbEdSeleccionar.DisplayMember = "Display";
            cmbEdSeleccionar.ValueMember   = "Id_Usuario";
            cmbEdSeleccionar.DataSource    = dtUsers;
            cmbEdSeleccionar.SelectedIndex = -1;
            cmbEdSeleccionar.Text          = "";
            LimpiarCamposEdicion();
        }

        // ─── NAVIGATION ─────────────────────────────────────────────────────────
        private void ShowPanel(Panel activePanel)
        {
            pnlAgregar.Visible      = (activePanel == pnlAgregar);
            pnlEditar.Visible       = (activePanel == pnlEditar);
            pnlAuditoria.Visible    = (activePanel == pnlAuditoria);
            pnlEstadoConex.Visible  = (activePanel == pnlEstadoConex);

            btnNavAgregar.BackColor     = (activePanel == pnlAgregar)     ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavEditar.BackColor      = (activePanel == pnlEditar)      ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavAuditoria.BackColor   = (activePanel == pnlAuditoria)   ? Color.FromArgb(37, 74, 123) : Color.Transparent;
            btnNavEstadoConex.BackColor = (activePanel == pnlEstadoConex) ? Color.FromArgb(37, 74, 123) : Color.Transparent;

            if      (activePanel == pnlAgregar)     lblHeaderTitle.Text = "AGREGAR NUEVO USUARIO";
            else if (activePanel == pnlEditar)      lblHeaderTitle.Text = "EDITAR USUARIO EXISTENTE";
            else if (activePanel == pnlAuditoria)   lblHeaderTitle.Text = "AUDITORÍA DE INICIOS DE SESIÓN";
            else if (activePanel == pnlEstadoConex) lblHeaderTitle.Text = "ESTADO DE CONEXIÓN A LA BASE DE DATOS";
        }

        // ─── CONNECTION STATUS (Mejorado visualmente) ────────────────────────────
        private void TestDatabaseConnection()
        {
            ActualizarEstadoConexion("Verificando...", ColorConCheck, "Comprobando conexión...");
            Application.DoEvents();

            string msg;
            bool isConnected = csConexion.TestConnection(out msg);

            if (isConnected)
                ActualizarEstadoConexion("● CONECTADO", ColorConOk,
                    $"Última comprobación: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n" +
                    $"Base de datos: Access (Aybar1.accdb)\n" +
                    $"Proveedor: Microsoft.ACE.OLEDB\n" +
                    $"Estado: {msg}");
            else
                ActualizarEstadoConexion("✖ DESCONECTADO", ColorConErr,
                    $"Última comprobación: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n" +
                    $"Base de datos: Access (Aybar1.accdb)\n" +
                    $"Error: {msg}");

            pnlConStatusIndicator.Invalidate();
        }

        private void ActualizarEstadoConexion(string status, Color color, string details)
        {
            lblConStatus.Text        = status;
            lblConStatus.ForeColor   = color;
            lblConDetails.Text       = details;
            pnlConStatusIndicator.BackColor = color;
            pnlConStatusIndicator.Invalidate();
        }

        // ─── NAV BUTTONS ─────────────────────────────────────────────────────────
        private void btnNavAgregar_Click(object sender, EventArgs e)    { ShowPanel(pnlAgregar); }
        private void btnNavEditar_Click(object sender, EventArgs e)     { ShowPanel(pnlEditar); CargarComboUsuariosEdicion(); }
        private void btnNavAuditoria_Click(object sender, EventArgs e)  { ShowPanel(pnlAuditoria); CargarAuditoriaGrid(); }
        private void btnNavEstadoConex_Click(object sender, EventArgs e){ ShowPanel(pnlEstadoConex); TestDatabaseConnection(); }

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
                Application.Exit();
        }

        // ─── VALIDATION HELPERS ──────────────────────────────────────────────────
        private bool ValidarCampo(TextBox txt, string nombre, int minLen = 1, bool soloLetras = false, bool soloNumeros = false, int maxLen = 0)
        {
            string val = txt.Text.Trim();
            errorProvider.SetError(txt, "");
            txt.BackColor = ColorNormal;

            if (string.IsNullOrEmpty(val) || val.Length < minLen)
            {
                MarcarError(txt, $"{nombre} es obligatorio (mín. {minLen} carácter/es).");
                return false;
            }
            if (maxLen > 0 && val.Length > maxLen)
            {
                MarcarError(txt, $"{nombre} no puede tener más de {maxLen} caracteres.");
                return false;
            }
            if (soloLetras && val.Any(char.IsDigit))
            {
                MarcarError(txt, $"{nombre} no puede contener números.");
                return false;
            }
            if (soloNumeros && val.Any(c => !char.IsDigit(c)))
            {
                MarcarError(txt, $"{nombre} solo puede contener números.");
                return false;
            }
            return true;
        }

        private void MarcarError(TextBox txt, string msg)
        {
            txt.BackColor = ColorError;
            errorProvider.SetError(txt, msg);
            toolTip.SetToolTip(txt, msg);
            txt.Focus();
        }

        private void LimpiarErrores(IEnumerable<Control> campos)
        {
            foreach (var txt in campos)
            {
                txt.BackColor = ColorNormal;
                errorProvider.SetError(txt, "");
                toolTip.SetToolTip(txt, "");
            }
        }

        // ─── AG: REDES SOCIALES ──────────────────────────────────────────────────
        private void btnAgAddRed_Click(object sender, EventArgs e)
        {
            string red     = cmbAgRedSocial.Text;
            string usuario = txtAgRedUser.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MarcarError(txtAgRedUser, "Ingrese el usuario de la red social.");
                return;
            }

            foreach (DataRow row in dtAgRedes.Rows)
                if (row["Red Social"].ToString() == red && row["Usuario"].ToString() == usuario)
                {
                    MessageBox.Show("Esta red social ya fue agregada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            dtAgRedes.Rows.Add(red, usuario);
            txtAgRedUser.Clear();
            txtAgRedUser.BackColor = ColorNormal;
            errorProvider.SetError(txtAgRedUser, "");
        }

        private void btnAgRemoveRed_Click(object sender, EventArgs e)
        {
            if (dgvAgRedes.CurrentRow != null)
                dgvAgRedes.Rows.RemoveAt(dgvAgRedes.CurrentRow.Index);
            else
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ─── AG: DOMICILIOS ──────────────────────────────────────────────────────
        private void btnAgAddDom_Click(object sender, EventArgs e)
        {
            string nombre = txtAgDomNombre.Text.Trim();
            string numero = txtAgDomNumero.Text.Trim();
            string tipo   = cmbAgDomTipo.Text;

            txtAgDomNombre.BackColor = ColorNormal;
            errorProvider.SetError(txtAgDomNombre, "");

            // Corrección: domicilio mín. 7 caracteres
            if (nombre.Length < 7)
            {
                MarcarError(txtAgDomNombre, "El domicilio debe tener al menos 7 caracteres.");
                return;
            }

            // Corrección: numero solo números
            if (!string.IsNullOrEmpty(numero) && numero.Any(c => !char.IsDigit(c)))
            {
                MarcarError(txtAgDomNumero, "El número de domicilio solo puede contener dígitos.");
                return;
            }

            string mapsLink = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(nombre + " " + numero);
            dtAgDomicilios.Rows.Add(nombre, numero, tipo, mapsLink);
            txtAgDomNombre.Clear();
            txtAgDomNumero.Clear();
            cmbAgDomTipo.SelectedIndex = 0;
        }

        private void btnAgRemoveDom_Click(object sender, EventArgs e)
        {
            if (dgvAgDomicilios.CurrentRow != null)
                dgvAgDomicilios.Rows.RemoveAt(dgvAgDomicilios.CurrentRow.Index);
            else
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAgMaps_Click(object sender, EventArgs e) { AbrirMapsDesdeGrid(dgvAgDomicilios); }

        private void AbrirMapsDesdeGrid(DataGridView dgv)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un domicilio de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string link = dgv.CurrentRow.Cells["Link Maps"].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(link))
            {
                string n = dgv.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                string num = dgv.CurrentRow.Cells["Numeracion"].Value?.ToString() ?? "";
                link = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(n + " " + num);
            }
            try { Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true }); }
            catch (Exception ex) { MessageBox.Show("No se pudo abrir Google Maps: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ─── AG: GUARDAR ─────────────────────────────────────────────────────────
        private void btnAgGuardar_Click(object sender, EventArgs e)
        {
            var todosLosCampos = new Control [] { txtAgNombre, txtAgApellido, txtAgDNI, txtAgPassword, txtAgMailLocal, txtAgCelular };
            LimpiarErrores(todosLosCampos);

            bool valido = true;

            // Corrección: Usuario = primer letra nombre + primer apellido; no puede contener números; máx 15
            valido &= ValidarCampo(txtAgNombre,   "Nombre",    1, soloLetras: true);
            valido &= ValidarCampo(txtAgApellido, "Apellido",  1, soloLetras: true);

            // Corrección: DNI 7 u 8 caracteres
            valido &= ValidarCampo(txtAgDNI,      "DNI",       7, soloNumeros: true, maxLen: 8);

            // Corrección: Contraseña máx 8 caracteres, no puede contener letras
            valido &= ValidarCampo(txtAgPassword, "Contraseña", 1, soloNumeros: true, maxLen: 8);

            // Corrección: Teléfono con +54
            string celular = "+54 " + txtAgCelular.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtAgCelular.Text.Trim()))
            {
                celular = "";
            }

            // Mail = local + dominio
            string mail = "";
            if (!string.IsNullOrEmpty(txtAgMailLocal.Text.Trim()))
                mail = txtAgMailLocal.Text.Trim() + cmbAgMailDominio.SelectedItem?.ToString();

            if (!valido) return;

            if (cmbAgPerfil.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un perfil válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPerfil = Convert.ToInt32(cmbAgPerfil.SelectedValue);

            // Build contacts list: celular + mail en una sola fila de Contacto
            var contactos = new List<Tuple<string, string, string>>();
            if (!string.IsNullOrEmpty(celular) || !string.IsNullOrEmpty(mail))
                contactos.Add(new Tuple<string, string, string>(celular, null, mail));

            // Social networks as individual rows
            foreach (DataRow row in dtAgRedes.Rows)
            {
                string redStr = $"{row["Red Social"]}: {row["Usuario"]}";
                contactos.Add(new Tuple<string, string, string>(null, redStr, null));
            }

            // Build addresses list
            var domicilios = new List<Tuple<string, string, string, string>>();
            foreach (DataRow row in dtAgDomicilios.Rows)
                domicilios.Add(new Tuple<string, string, string, string>(
                    row["Nombre"].ToString(),
                    row["Numeracion"].ToString(),
                    row["Tipo"].ToString(),
                    row["Link Maps"].ToString()));

            try
            {
                string nombre   = txtAgNombre.Text.Trim();
                string apellido = txtAgApellido.Text.Trim();
                string dni      = txtAgDNI.Text.Trim();
                string pass     = txtAgPassword.Text.Trim();

                int newUserId = csMetodos.AgregarUsuario(nombre, apellido, dni, pass, mail, idPerfil, contactos, domicilios);
                MessageBox.Show($"Usuario '{nombre} {apellido}' registrado con éxito (ID: {newUserId}).",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAgLimpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgLimpiar_Click(object sender, EventArgs e)
        {
            txtAgNombre.Clear(); txtAgApellido.Clear(); txtAgDNI.Clear();
            txtAgPassword.Clear(); txtAgMailLocal.Clear(); txtAgCelular.Clear();
            txtAgRedUser.Clear(); txtAgDomNombre.Clear(); txtAgDomNumero.Clear();

            if (cmbAgPerfil.Items.Count > 0)    cmbAgPerfil.SelectedIndex = 0;
            if (cmbAgProvincia.Items.Count > 0)  cmbAgProvincia.SelectedIndex = 0;
            if (cmbAgLocalidad.Items.Count > 0)  cmbAgLocalidad.SelectedIndex = -1;
            cmbAgLocalidad.Enabled = false;
            cmbAgRedSocial.SelectedIndex  = 0;
            cmbAgDomTipo.SelectedIndex    = 0;
            cmbAgMailDominio.SelectedIndex = 0;

            dtAgRedes.Rows.Clear();
            dtAgDomicilios.Rows.Clear();

            LimpiarErrores(new  Control [] { txtAgNombre, txtAgApellido, txtAgDNI, txtAgPassword, txtAgMailLocal, txtAgCelular, txtAgRedUser, txtAgDomNombre, txtAgDomNumero });

            
            chkAgMostrarPass.Checked = false;
        }

        // Corrección: Mostrar contraseña en Agregar
        private void chkAgMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txtAgPassword.UseSystemPasswordChar = !chkAgMostrarPass.Checked;
        }

        // ─── ED: SELECCIÓN ───────────────────────────────────────────────────────
        private void cmbEdSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                LimpiarCamposEdicion();
                return;
            }

            int idUsuario;
            if (!int.TryParse(cmbEdSeleccionar.SelectedValue.ToString(), out idUsuario)) return;

            try
            {
                DataRow userRow = csMetodos.ObtenerDetalleUsuario(idUsuario);
                if (userRow == null) return;

                lblEdActNomVal.Text  = userRow["Nombre"].ToString();
                lblEdActApeVal.Text  = userRow["Apellido"].ToString();
                lblEdActDNIVal.Text  = userRow["DNI"].ToString();
                lblEdActPassVal.Text = userRow["Contraseña"].ToString();
                lblEdActMailVal.Text = userRow["Mail"].ToString();

                txtEdNombre.Text   = userRow["Nombre"].ToString();
                txtEdApellido.Text = userRow["Apellido"].ToString();
                txtEdDNI.Text      = userRow["DNI"].ToString();
                txtEdPassword.Text = userRow["Contraseña"].ToString();

                // Split mail into local + dominio
                string fullMail = userRow["Mail"].ToString();
                int atIdx = fullMail.IndexOf('@');
                if (atIdx >= 0)
                {
                    txtEdMailLocal.Text    = fullMail.Substring(0, atIdx);
                    string dom = fullMail.Substring(atIdx);
                    int domIdx = cmbEdMailDominio.Items.IndexOf(dom);
                    cmbEdMailDominio.SelectedIndex = domIdx >= 0 ? domIdx : 0;
                }
                else
                {
                    txtEdMailLocal.Text = fullMail;
                    cmbEdMailDominio.SelectedIndex = 0;
                }

                int idPerfil = csMetodos.ObtenerPerfilUsuario(idUsuario);
                cmbEdPerfil.SelectedValue = idPerfil;

                DataTable dtP = (DataTable)cmbEdPerfil.DataSource;
                if (dtP != null)
                {
                    DataRow[] pRows = dtP.Select($"Id_Perfil = {idPerfil}");
                    lblEdActPerfilVal.Text = pRows.Length > 0 ? pRows[0]["Nombre"].ToString() : "-";
                }

                // Contactos
                dtEdRedes.Rows.Clear();
                txtEdCelular.Clear();

                DataTable contactsTable = csMetodos.ObtenerContactosUsuario(idUsuario);
                foreach (DataRow r in contactsTable.Rows)
                {
                    string cel = r["Numero Celular"].ToString();
                    if (!string.IsNullOrEmpty(cel) && string.IsNullOrEmpty(txtEdCelular.Text))
                    {
                        // Corrección: mostrar número de teléfono en datos actuales
                        txtEdCelular.Text = cel;
                        lblEdActCelularVal.Text = cel;
                    }

                    string redStr = r["Redes Sociales"].ToString();
                    if (!string.IsNullOrEmpty(redStr))
                    {
                        string[] parts = redStr.Split(new[] { ": " }, StringSplitOptions.None);
                        dtEdRedes.Rows.Add(parts.Length >= 2 ? parts[0] : "Otro", parts.Length >= 2 ? parts[1] : redStr);
                    }
                }

                // Domicilios
                dtEdDomicilios.Rows.Clear();
                DataTable addressesTable = csMetodos.ObtenerDomiciliosUsuario(idUsuario);
                foreach (DataRow r in addressesTable.Rows)
                    dtEdDomicilios.Rows.Add(r["Nombre"].ToString(), r["Numeracion"].ToString(), r["Tipo"].ToString(), r["Link Maps"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposEdicion()
        {
            lblEdActNomVal.Text     = "-"; lblEdActApeVal.Text  = "-";
            lblEdActDNIVal.Text     = "-"; lblEdActPassVal.Text = "-";
            lblEdActMailVal.Text    = "-"; lblEdActPerfilVal.Text = "-";
            lblEdActCelularVal.Text = "-";

            txtEdNombre.Clear(); txtEdApellido.Clear(); txtEdDNI.Clear();
            txtEdPassword.Clear(); txtEdMailLocal.Clear(); txtEdCelular.Clear();
            txtEdRedUser.Clear(); txtEdDomNombre.Clear(); txtEdDomNumero.Clear();

            if (cmbEdPerfil.Items.Count > 0) cmbEdPerfil.SelectedIndex = -1;
            cmbEdRedSocial.SelectedIndex  = 0;
            cmbEdDomTipo.SelectedIndex    = 0;
            cmbEdMailDominio.SelectedIndex = 0;

            dtEdRedes.Rows.Clear();
            dtEdDomicilios.Rows.Clear();
        }

        // ─── ED: REDES ───────────────────────────────────────────────────────────
        private void btnEdAddRed_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1) return;
            string red  = cmbEdRedSocial.Text;
            string user = txtEdRedUser.Text.Trim();

            if (string.IsNullOrEmpty(user)) { MarcarError(txtEdRedUser, "Ingrese el usuario de la red social."); return; }

            dtEdRedes.Rows.Add(red, user);
            txtEdRedUser.Clear();
            txtEdRedUser.BackColor = ColorNormal;
            errorProvider.SetError(txtEdRedUser, "");
        }

        private void btnEdRemoveRed_Click(object sender, EventArgs e)
        {
            if (dgvEdRedes.CurrentRow != null)
                dgvEdRedes.Rows.RemoveAt(dgvEdRedes.CurrentRow.Index);
        }

        // ─── ED: DOMICILIOS ──────────────────────────────────────────────────────
        private void btnEdAddDom_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1) return;
            string nombre = txtEdDomNombre.Text.Trim();
            string numero = txtEdDomNumero.Text.Trim();

            txtEdDomNombre.BackColor = ColorNormal;
            errorProvider.SetError(txtEdDomNombre, "");

            if (nombre.Length < 7) { MarcarError(txtEdDomNombre, "El domicilio debe tener al menos 7 caracteres."); return; }
            if (!string.IsNullOrEmpty(numero) && numero.Any(c => !char.IsDigit(c))) { MarcarError(txtEdDomNumero, "Solo se permiten dígitos."); return; }

            string mapsLink = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(nombre + " " + numero);
            dtEdDomicilios.Rows.Add(nombre, numero, cmbEdDomTipo.Text, mapsLink);
            txtEdDomNombre.Clear(); txtEdDomNumero.Clear();
        }

        private void btnEdRemoveDom_Click(object sender, EventArgs e)
        {
            if (dgvEdDomicilios.CurrentRow != null)
                dgvEdDomicilios.Rows.RemoveAt(dgvEdDomicilios.CurrentRow.Index);
        }

        private void btnEdMaps_Click(object sender, EventArgs e) { AbrirMapsDesdeGrid(dgvEdDomicilios); }

        // ─── ED: GUARDAR ─────────────────────────────────────────────────────────
        private void btnEdGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un usuario para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var todosLosCampos = new[] { txtEdNombre, txtEdApellido, txtEdDNI, txtEdPassword, txtEdMailLocal };
            LimpiarErrores(todosLosCampos);

            bool valido = true;
            valido &= ValidarCampo(txtEdNombre,    "Nombre",    1, soloLetras: true);
            valido &= ValidarCampo(txtEdApellido,  "Apellido",  1, soloLetras: true);
            valido &= ValidarCampo(txtEdDNI,       "DNI",       7, soloNumeros: true, maxLen: 8);
            valido &= ValidarCampo(txtEdPassword,  "Contraseña", 1, soloNumeros: true, maxLen: 8);
            if (!valido) return;

            int idUsuario = Convert.ToInt32(cmbEdSeleccionar.SelectedValue);
            string nombre   = txtEdNombre.Text.Trim();
            string apellido = txtEdApellido.Text.Trim();
            string dni      = txtEdDNI.Text.Trim();
            string pass     = txtEdPassword.Text.Trim();
            string mail     = string.IsNullOrEmpty(txtEdMailLocal.Text.Trim()) ? "" : txtEdMailLocal.Text.Trim() + cmbEdMailDominio.SelectedItem?.ToString();
            string celular  = string.IsNullOrWhiteSpace(txtEdCelular.Text.Trim()) ? "" : "+54 " + txtEdCelular.Text.Trim();
            int idPerfil    = Convert.ToInt32(cmbEdPerfil.SelectedValue);

            var contactos = new List<Tuple<string, string, string>>();
            if (!string.IsNullOrEmpty(celular) || !string.IsNullOrEmpty(mail))
                contactos.Add(new Tuple<string, string, string>(celular, null, mail));

            foreach (DataRow row in dtEdRedes.Rows)
                contactos.Add(new Tuple<string, string, string>(null, $"{row["Red Social"]}: {row["Usuario"]}", null));

            var domicilios = new List<Tuple<string, string, string, string>>();
            foreach (DataRow row in dtEdDomicilios.Rows)
                domicilios.Add(new Tuple<string, string, string, string>(
                    row["Nombre"].ToString(), row["Numeracion"].ToString(), row["Tipo"].ToString(), row["Link Maps"].ToString()));

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

        // ─── ED: BAJA ────────────────────────────────────────────────────────────
        private void btnEdBaja_Click(object sender, EventArgs e)
        {
            if (cmbEdSeleccionar.SelectedIndex == -1 || cmbEdSeleccionar.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un usuario para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario    = Convert.ToInt32(cmbEdSeleccionar.SelectedValue);
            string userDisplay = cmbEdSeleccionar.Text;

            if (MessageBox.Show($"¿Está seguro de dar de baja a '{userDisplay}'?\nPasará a estado inactivo.",
                "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (csMetodos.DarDeBajaUsuario(idUsuario))
                    {
                        MessageBox.Show("El usuario fue dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarComboUsuariosEdicion();
                    }
                    else
                        MessageBox.Show("No se pudo dar de baja al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── AUDITORÍA (Mejorada con búsqueda) ──────────────────────────────────
        private DataTable dtAuditoriaCompleta;

        private void CargarAuditoriaGrid()
        {
            try
            {
                dtAuditoriaCompleta = csMetodos.ObtenerAuditoria();
                dgvAuditoria.DataSource = dtAuditoriaCompleta;
                EstilizarColumnasAuditoria();
                AplicarEstiloGrilla(dgvAuditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstilizarColumnasAuditoria()
        {
            if (dgvAuditoria.Columns.Count == 0) return;

            if (dgvAuditoria.Columns.Contains("Id_Auditoria"))
            { dgvAuditoria.Columns["Id_Auditoria"].HeaderText = "ID";       dgvAuditoria.Columns["Id_Auditoria"].Width = 55; }
            if (dgvAuditoria.Columns.Contains("Fecha"))
            { dgvAuditoria.Columns["Fecha"].HeaderText = "Fecha";           dgvAuditoria.Columns["Fecha"].Width = 100; }
            if (dgvAuditoria.Columns.Contains("Hora"))
            { dgvAuditoria.Columns["Hora"].HeaderText = "Hora";             dgvAuditoria.Columns["Hora"].Width = 90; }
            if (dgvAuditoria.Columns.Contains("Usuario"))
            { dgvAuditoria.Columns["Usuario"].HeaderText = "Usuario";       dgvAuditoria.Columns["Usuario"].Width = 160; }
            if (dgvAuditoria.Columns.Contains("Detalle"))
            { dgvAuditoria.Columns["Detalle"].HeaderText = "Detalle";       dgvAuditoria.Columns["Detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
        }

        // Corrección: búsqueda de auditoría por DNI/usuario, fecha y hora
        private void txtAudBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarAuditoria();
        }

        private void dtpAudFecha_ValueChanged(object sender, EventArgs e)
        {
            FiltrarAuditoria();
        }

        private void chkAudFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpAudFecha.Enabled = chkAudFiltrarFecha.Checked;
            FiltrarAuditoria();
        }

        private void FiltrarAuditoria()
        {
            if (dtAuditoriaCompleta == null) return;

            string buscar = txtAudBuscar.Text.Trim().ToLower();
            string filtro = "";

            if (!string.IsNullOrEmpty(buscar))
                filtro = $"(Convert([Usuario], 'System.String') LIKE '%{buscar}%')";

            if (chkAudFiltrarFecha.Checked)
            {
                string fecha = dtpAudFecha.Value.ToString("yyyy-MM-dd");
                string filtrF = $"Convert([Fecha], 'System.String') LIKE '%{dtpAudFecha.Value:dd/MM/yyyy}%'";
                filtro = string.IsNullOrEmpty(filtro) ? filtrF : filtro + " AND " + filtrF;
            }

            try
            {
                DataView dv  = dtAuditoriaCompleta.DefaultView;
                dv.RowFilter = filtro;
                dgvAuditoria.DataSource = dv.ToTable();
                EstilizarColumnasAuditoria();
            }
            catch { }
        }

        private void btnAudRefrescar_Click(object sender, EventArgs e)
        {
            txtAudBuscar.Clear();
            chkAudFiltrarFecha.Checked = false;
            CargarAuditoriaGrid();
        }

        // ─── ESTADO CONEXIÓN ─────────────────────────────────────────────────────
        private void btnConReconectar_Click(object sender, EventArgs e) { TestDatabaseConnection(); }

        private void pnlConStatusIndicator_Paint(object sender, PaintEventArgs e)
        {
            int size = 80;
            int x    = (pnlConStatusIndicator.Width  - size) / 2;
            int y    = (pnlConStatusIndicator.Height - size) / 2;

            using (var brush = new SolidBrush(pnlConStatusIndicator.BackColor))
                e.Graphics.FillEllipse(brush, x, y, size, size);

            using (var pen = new Pen(Color.FromArgb(60, 60, 60), 2))
                e.Graphics.DrawEllipse(pen, x, y, size, size);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}
