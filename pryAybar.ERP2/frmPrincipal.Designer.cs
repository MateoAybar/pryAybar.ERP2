namespace pryAybar.ERP2
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSessionPerfil = new System.Windows.Forms.Label();
            this.lblSessionUser = new System.Windows.Forms.Label();
            this.pnlSessionDivider = new System.Windows.Forms.Panel();
            this.btnNavSalir = new System.Windows.Forms.Button();
            this.btnNavCerrarSesion = new System.Windows.Forms.Button();
            this.btnNavEstadoConex = new System.Windows.Forms.Button();
            this.btnNavAuditoria = new System.Windows.Forms.Button();
            this.btnNavEditar = new System.Windows.Forms.Button();
            this.btnNavAgregar = new System.Windows.Forms.Button();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgLimpiar = new System.Windows.Forms.Button();
            this.btnAgGuardar = new System.Windows.Forms.Button();
            this.grpAgDomicilios = new System.Windows.Forms.GroupBox();
            this.btnAgMaps = new System.Windows.Forms.Button();
            this.btnAgRemoveDom = new System.Windows.Forms.Button();
            this.btnAgAddDom = new System.Windows.Forms.Button();
            this.dgvAgDomicilios = new System.Windows.Forms.DataGridView();
            this.cmbAgDomTipo = new System.Windows.Forms.ComboBox();
            this.lblAgDomTipo = new System.Windows.Forms.Label();
            this.txtAgDomNumero = new System.Windows.Forms.TextBox();
            this.lblAgDomNumero = new System.Windows.Forms.Label();
            this.txtAgDomNombre = new System.Windows.Forms.TextBox();
            this.lblAgDomNombre = new System.Windows.Forms.Label();
            this.grpAgContacto = new System.Windows.Forms.GroupBox();
            this.btnAgRemoveRed = new System.Windows.Forms.Button();
            this.btnAgAddRed = new System.Windows.Forms.Button();
            this.dgvAgRedes = new System.Windows.Forms.DataGridView();
            this.txtAgRedUser = new System.Windows.Forms.TextBox();
            this.lblAgRedUser = new System.Windows.Forms.Label();
            this.cmbAgRedSocial = new System.Windows.Forms.ComboBox();
            this.lblAgRedSocial = new System.Windows.Forms.Label();
            this.lblAgCelular = new System.Windows.Forms.Label();
            this.grpAgPersonales = new System.Windows.Forms.GroupBox();
            this.cmbAgLocalidad = new System.Windows.Forms.ComboBox();
            this.lblAgLocalidad = new System.Windows.Forms.Label();
            this.cmbAgProvincia = new System.Windows.Forms.ComboBox();
            this.lblAgProvincia = new System.Windows.Forms.Label();
            this.cmbAgPerfil = new System.Windows.Forms.ComboBox();
            this.lblAgPerfil = new System.Windows.Forms.Label();
            this.txtAgMail = new System.Windows.Forms.TextBox();
            this.lblAgMail = new System.Windows.Forms.Label();
            this.txtAgPassword = new System.Windows.Forms.TextBox();
            this.lblAgPassword = new System.Windows.Forms.Label();
            this.txtAgDNI = new System.Windows.Forms.TextBox();
            this.lblAgDNI = new System.Windows.Forms.Label();
            this.txtAgApellido = new System.Windows.Forms.TextBox();
            this.lblAgApellido = new System.Windows.Forms.Label();
            this.txtAgNombre = new System.Windows.Forms.TextBox();
            this.lblAgNombre = new System.Windows.Forms.Label();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.btnEdBaja = new System.Windows.Forms.Button();
            this.btnEdGuardar = new System.Windows.Forms.Button();
            this.grpEdDomicilios = new System.Windows.Forms.GroupBox();
            this.btnEdMaps = new System.Windows.Forms.Button();
            this.btnEdRemoveDom = new System.Windows.Forms.Button();
            this.btnEdAddDom = new System.Windows.Forms.Button();
            this.dgvEdDomicilios = new System.Windows.Forms.DataGridView();
            this.cmbEdDomTipo = new System.Windows.Forms.ComboBox();
            this.lblEdDomTipo = new System.Windows.Forms.Label();
            this.txtEdDomNumero = new System.Windows.Forms.TextBox();
            this.lblEdDomNumero = new System.Windows.Forms.Label();
            this.txtEdDomNombre = new System.Windows.Forms.TextBox();
            this.lblEdDomNombre = new System.Windows.Forms.Label();
            this.grpEdContacto = new System.Windows.Forms.GroupBox();
            this.btnEdRemoveRed = new System.Windows.Forms.Button();
            this.btnEdAddRed = new System.Windows.Forms.Button();
            this.dgvEdRedes = new System.Windows.Forms.DataGridView();
            this.txtEdRedUser = new System.Windows.Forms.TextBox();
            this.lblEdRedUser = new System.Windows.Forms.Label();
            this.cmbEdRedSocial = new System.Windows.Forms.ComboBox();
            this.lblEdRedSocial = new System.Windows.Forms.Label();
            this.txtEdCelular = new System.Windows.Forms.TextBox();
            this.lblEdCelular = new System.Windows.Forms.Label();
            this.grpEdNuevosDatos = new System.Windows.Forms.GroupBox();
            this.cmbEdPerfil = new System.Windows.Forms.ComboBox();
            this.lblEdPerfil = new System.Windows.Forms.Label();
            this.txtEdMail = new System.Windows.Forms.TextBox();
            this.lblEdMail = new System.Windows.Forms.Label();
            this.txtEdPassword = new System.Windows.Forms.TextBox();
            this.lblEdPassword = new System.Windows.Forms.Label();
            this.txtEdDNI = new System.Windows.Forms.TextBox();
            this.lblEdDNI = new System.Windows.Forms.Label();
            this.txtEdApellido = new System.Windows.Forms.TextBox();
            this.lblEdApellido = new System.Windows.Forms.Label();
            this.txtEdNombre = new System.Windows.Forms.TextBox();
            this.lblEdNombre = new System.Windows.Forms.Label();
            this.grpEdActuales = new System.Windows.Forms.GroupBox();
            this.lblEdActPerfilVal = new System.Windows.Forms.Label();
            this.lblEdActMailVal = new System.Windows.Forms.Label();
            this.lblEdActPassVal = new System.Windows.Forms.Label();
            this.lblEdActDNIVal = new System.Windows.Forms.Label();
            this.lblEdActApeVal = new System.Windows.Forms.Label();
            this.lblEdActNomVal = new System.Windows.Forms.Label();
            this.lblEdActPerfil = new System.Windows.Forms.Label();
            this.lblEdActMail = new System.Windows.Forms.Label();
            this.lblEdActPass = new System.Windows.Forms.Label();
            this.lblEdActDNI = new System.Windows.Forms.Label();
            this.lblEdActApe = new System.Windows.Forms.Label();
            this.lblEdActNom = new System.Windows.Forms.Label();
            this.pnlEdSeleccionar = new System.Windows.Forms.Panel();
            this.cmbEdSeleccionar = new System.Windows.Forms.ComboBox();
            this.lblEdSeleccionar = new System.Windows.Forms.Label();
            this.pnlAuditoria = new System.Windows.Forms.Panel();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.pnlAuditoriaHeader = new System.Windows.Forms.Panel();
            this.btnAudRefrescar = new System.Windows.Forms.Button();
            this.lblAudTitle = new System.Windows.Forms.Label();
            this.pnlEstadoConex = new System.Windows.Forms.Panel();
            this.pnlConCard = new System.Windows.Forms.Panel();
            this.btnConReconectar = new System.Windows.Forms.Button();
            this.lblConDetails = new System.Windows.Forms.Label();
            this.lblConStatus = new System.Windows.Forms.Label();
            this.pnlConStatusIndicator = new System.Windows.Forms.Panel();
            this.txtAgCelular = new System.Windows.Forms.MaskedTextBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            this.grpAgDomicilios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgDomicilios)).BeginInit();
            this.grpAgContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgRedes)).BeginInit();
            this.grpAgPersonales.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            this.grpEdDomicilios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdDomicilios)).BeginInit();
            this.grpEdContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdRedes)).BeginInit();
            this.grpEdNuevosDatos.SuspendLayout();
            this.grpEdActuales.SuspendLayout();
            this.pnlEdSeleccionar.SuspendLayout();
            this.pnlAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.pnlAuditoriaHeader.SuspendLayout();
            this.pnlEstadoConex.SuspendLayout();
            this.pnlConCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.pnlSidebar.Controls.Add(this.lblSessionPerfil);
            this.pnlSidebar.Controls.Add(this.lblSessionUser);
            this.pnlSidebar.Controls.Add(this.pnlSessionDivider);
            this.pnlSidebar.Controls.Add(this.btnNavSalir);
            this.pnlSidebar.Controls.Add(this.btnNavCerrarSesion);
            this.pnlSidebar.Controls.Add(this.btnNavEstadoConex);
            this.pnlSidebar.Controls.Add(this.btnNavAuditoria);
            this.pnlSidebar.Controls.Add(this.btnNavEditar);
            this.pnlSidebar.Controls.Add(this.btnNavAgregar);
            this.pnlSidebar.Controls.Add(this.lblSidebarLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 650);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblSessionPerfil
            // 
            this.lblSessionPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.lblSessionPerfil.Location = new System.Drawing.Point(12, 110);
            this.lblSessionPerfil.Name = "lblSessionPerfil";
            this.lblSessionPerfil.Size = new System.Drawing.Size(196, 20);
            this.lblSessionPerfil.TabIndex = 9;
            this.lblSessionPerfil.Text = "Administrador";
            this.lblSessionPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSessionUser
            // 
            this.lblSessionUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionUser.ForeColor = System.Drawing.Color.White;
            this.lblSessionUser.Location = new System.Drawing.Point(12, 85);
            this.lblSessionUser.Name = "lblSessionUser";
            this.lblSessionUser.Size = new System.Drawing.Size(196, 23);
            this.lblSessionUser.TabIndex = 8;
            this.lblSessionUser.Text = "Admin Admin";
            this.lblSessionUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSessionDivider
            // 
            this.pnlSessionDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.pnlSessionDivider.Location = new System.Drawing.Point(15, 140);
            this.pnlSessionDivider.Name = "pnlSessionDivider";
            this.pnlSessionDivider.Size = new System.Drawing.Size(190, 2);
            this.pnlSessionDivider.TabIndex = 7;
            // 
            // btnNavSalir
            // 
            this.btnNavSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSalir.FlatAppearance.BorderSize = 0;
            this.btnNavSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnNavSalir.Location = new System.Drawing.Point(0, 580);
            this.btnNavSalir.Name = "btnNavSalir";
            this.btnNavSalir.Size = new System.Drawing.Size(220, 45);
            this.btnNavSalir.TabIndex = 6;
            this.btnNavSalir.Text = "SALIR";
            this.btnNavSalir.UseVisualStyleBackColor = true;
            this.btnNavSalir.Click += new System.EventHandler(this.btnNavSalir_Click);
            // 
            // btnNavCerrarSesion
            // 
            this.btnNavCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnNavCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnNavCerrarSesion.Location = new System.Drawing.Point(0, 530);
            this.btnNavCerrarSesion.Name = "btnNavCerrarSesion";
            this.btnNavCerrarSesion.Size = new System.Drawing.Size(220, 45);
            this.btnNavCerrarSesion.TabIndex = 5;
            this.btnNavCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnNavCerrarSesion.UseVisualStyleBackColor = true;
            this.btnNavCerrarSesion.Click += new System.EventHandler(this.btnNavCerrarSesion_Click);
            // 
            // btnNavEstadoConex
            // 
            this.btnNavEstadoConex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavEstadoConex.FlatAppearance.BorderSize = 0;
            this.btnNavEstadoConex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavEstadoConex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavEstadoConex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEstadoConex.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEstadoConex.ForeColor = System.Drawing.Color.White;
            this.btnNavEstadoConex.Location = new System.Drawing.Point(0, 310);
            this.btnNavEstadoConex.Name = "btnNavEstadoConex";
            this.btnNavEstadoConex.Size = new System.Drawing.Size(220, 45);
            this.btnNavEstadoConex.TabIndex = 4;
            this.btnNavEstadoConex.Text = "Estado BD";
            this.btnNavEstadoConex.UseVisualStyleBackColor = true;
            this.btnNavEstadoConex.Click += new System.EventHandler(this.btnNavEstadoConex_Click);
            // 
            // btnNavAuditoria
            // 
            this.btnNavAuditoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAuditoria.FlatAppearance.BorderSize = 0;
            this.btnNavAuditoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavAuditoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAuditoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAuditoria.ForeColor = System.Drawing.Color.White;
            this.btnNavAuditoria.Location = new System.Drawing.Point(0, 260);
            this.btnNavAuditoria.Name = "btnNavAuditoria";
            this.btnNavAuditoria.Size = new System.Drawing.Size(220, 45);
            this.btnNavAuditoria.TabIndex = 3;
            this.btnNavAuditoria.Text = "Auditoría";
            this.btnNavAuditoria.UseVisualStyleBackColor = true;
            this.btnNavAuditoria.Click += new System.EventHandler(this.btnNavAuditoria_Click);
            // 
            // btnNavEditar
            // 
            this.btnNavEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavEditar.FlatAppearance.BorderSize = 0;
            this.btnNavEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavEditar.ForeColor = System.Drawing.Color.White;
            this.btnNavEditar.Location = new System.Drawing.Point(0, 210);
            this.btnNavEditar.Name = "btnNavEditar";
            this.btnNavEditar.Size = new System.Drawing.Size(220, 45);
            this.btnNavEditar.TabIndex = 2;
            this.btnNavEditar.Text = "Editar Usuario";
            this.btnNavEditar.UseVisualStyleBackColor = true;
            this.btnNavEditar.Click += new System.EventHandler(this.btnNavEditar_Click);
            // 
            // btnNavAgregar
            // 
            this.btnNavAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAgregar.FlatAppearance.BorderSize = 0;
            this.btnNavAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnNavAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(74)))), ((int)(((byte)(123)))));
            this.btnNavAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAgregar.ForeColor = System.Drawing.Color.White;
            this.btnNavAgregar.Location = new System.Drawing.Point(0, 160);
            this.btnNavAgregar.Name = "btnNavAgregar";
            this.btnNavAgregar.Size = new System.Drawing.Size(220, 45);
            this.btnNavAgregar.TabIndex = 7;
            this.btnNavAgregar.Text = "Agregar Usuario";
            this.btnNavAgregar.UseVisualStyleBackColor = true;
            this.btnNavAgregar.Click += new System.EventHandler(this.btnNavAgregar_Click);
            // 
            // lblSidebarLogo
            // 
            this.lblSidebarLogo.AutoSize = true;
            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.White;
            this.lblSidebarLogo.Location = new System.Drawing.Point(34, 18);
            this.lblSidebarLogo.Name = "lblSidebarLogo";
            this.lblSidebarLogo.Size = new System.Drawing.Size(143, 32);
            this.lblSidebarLogo.TabIndex = 0;
            this.lblSidebarLogo.Text = "AYBAR ERP";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(189, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "AGREGAR USUARIO";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlContent.Controls.Add(this.pnlAgregar);
            this.pnlContent.Controls.Add(this.pnlEditar);
            this.pnlContent.Controls.Add(this.pnlAuditoria);
            this.pnlContent.Controls.Add(this.pnlEstadoConex);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(780, 590);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnAgLimpiar);
            this.pnlAgregar.Controls.Add(this.btnAgGuardar);
            this.pnlAgregar.Controls.Add(this.grpAgDomicilios);
            this.pnlAgregar.Controls.Add(this.grpAgContacto);
            this.pnlAgregar.Controls.Add(this.grpAgPersonales);
            this.pnlAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAgregar.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(780, 590);
            this.pnlAgregar.TabIndex = 0;
            // 
            // btnAgLimpiar
            // 
            this.btnAgLimpiar.BackColor = System.Drawing.Color.White;
            this.btnAgLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAgLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAgLimpiar.Location = new System.Drawing.Point(20, 530);
            this.btnAgLimpiar.Name = "btnAgLimpiar";
            this.btnAgLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnAgLimpiar.TabIndex = 4;
            this.btnAgLimpiar.Text = "Limpiar Campos";
            this.btnAgLimpiar.UseVisualStyleBackColor = false;
            this.btnAgLimpiar.Click += new System.EventHandler(this.btnAgLimpiar_Click);
            // 
            // btnAgGuardar
            // 
            this.btnAgGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAgGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgGuardar.FlatAppearance.BorderSize = 0;
            this.btnAgGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgGuardar.ForeColor = System.Drawing.Color.White;
            this.btnAgGuardar.Location = new System.Drawing.Point(610, 530);
            this.btnAgGuardar.Name = "btnAgGuardar";
            this.btnAgGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnAgGuardar.TabIndex = 3;
            this.btnAgGuardar.Text = "Guardar Usuario";
            this.btnAgGuardar.UseVisualStyleBackColor = false;
            this.btnAgGuardar.Click += new System.EventHandler(this.btnAgGuardar_Click);
            // 
            // grpAgDomicilios
            // 
            this.grpAgDomicilios.BackColor = System.Drawing.Color.White;
            this.grpAgDomicilios.Controls.Add(this.btnAgMaps);
            this.grpAgDomicilios.Controls.Add(this.btnAgRemoveDom);
            this.grpAgDomicilios.Controls.Add(this.btnAgAddDom);
            this.grpAgDomicilios.Controls.Add(this.dgvAgDomicilios);
            this.grpAgDomicilios.Controls.Add(this.cmbAgDomTipo);
            this.grpAgDomicilios.Controls.Add(this.lblAgDomTipo);
            this.grpAgDomicilios.Controls.Add(this.txtAgDomNumero);
            this.grpAgDomicilios.Controls.Add(this.lblAgDomNumero);
            this.grpAgDomicilios.Controls.Add(this.txtAgDomNombre);
            this.grpAgDomicilios.Controls.Add(this.lblAgDomNombre);
            this.grpAgDomicilios.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgDomicilios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpAgDomicilios.Location = new System.Drawing.Point(375, 271);
            this.grpAgDomicilios.Name = "grpAgDomicilios";
            this.grpAgDomicilios.Size = new System.Drawing.Size(385, 244);
            this.grpAgDomicilios.TabIndex = 2;
            this.grpAgDomicilios.TabStop = false;
            this.grpAgDomicilios.Text = "Domicilios";
            // 
            // btnAgMaps
            // 
            this.btnAgMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgMaps.FlatAppearance.BorderSize = 0;
            this.btnAgMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgMaps.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgMaps.ForeColor = System.Drawing.Color.White;
            this.btnAgMaps.Location = new System.Drawing.Point(280, 210);
            this.btnAgMaps.Name = "btnAgMaps";
            this.btnAgMaps.Size = new System.Drawing.Size(95, 27);
            this.btnAgMaps.TabIndex = 9;
            this.btnAgMaps.Text = "Maps";
            this.btnAgMaps.UseVisualStyleBackColor = false;
            this.btnAgMaps.Click += new System.EventHandler(this.btnAgMaps_Click);
            // 
            // btnAgRemoveDom
            // 
            this.btnAgRemoveDom.BackColor = System.Drawing.Color.Crimson;
            this.btnAgRemoveDom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgRemoveDom.FlatAppearance.BorderSize = 0;
            this.btnAgRemoveDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgRemoveDom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgRemoveDom.ForeColor = System.Drawing.Color.White;
            this.btnAgRemoveDom.Location = new System.Drawing.Point(180, 210);
            this.btnAgRemoveDom.Name = "btnAgRemoveDom";
            this.btnAgRemoveDom.Size = new System.Drawing.Size(95, 27);
            this.btnAgRemoveDom.TabIndex = 8;
            this.btnAgRemoveDom.Text = "Quitar";
            this.btnAgRemoveDom.UseVisualStyleBackColor = false;
            this.btnAgRemoveDom.Click += new System.EventHandler(this.btnAgRemoveDom_Click);
            // 
            // btnAgAddDom
            // 
            this.btnAgAddDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAgAddDom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgAddDom.FlatAppearance.BorderSize = 0;
            this.btnAgAddDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgAddDom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgAddDom.ForeColor = System.Drawing.Color.White;
            this.btnAgAddDom.Location = new System.Drawing.Point(280, 84);
            this.btnAgAddDom.Name = "btnAgAddDom";
            this.btnAgAddDom.Size = new System.Drawing.Size(95, 25);
            this.btnAgAddDom.TabIndex = 7;
            this.btnAgAddDom.Text = "Agregar";
            this.btnAgAddDom.UseVisualStyleBackColor = false;
            this.btnAgAddDom.Click += new System.EventHandler(this.btnAgAddDom_Click);
            // 
            // dgvAgDomicilios
            // 
            this.dgvAgDomicilios.AllowUserToAddRows = false;
            this.dgvAgDomicilios.AllowUserToDeleteRows = false;
            this.dgvAgDomicilios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgDomicilios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dgvAgDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgDomicilios.Location = new System.Drawing.Point(15, 117);
            this.dgvAgDomicilios.Name = "dgvAgDomicilios";
            this.dgvAgDomicilios.ReadOnly = true;
            this.dgvAgDomicilios.RowHeadersVisible = false;
            this.dgvAgDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgDomicilios.Size = new System.Drawing.Size(360, 88);
            this.dgvAgDomicilios.TabIndex = 6;
            // 
            // cmbAgDomTipo
            // 
            this.cmbAgDomTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgDomTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgDomTipo.FormattingEnabled = true;
            this.cmbAgDomTipo.Location = new System.Drawing.Point(15, 84);
            this.cmbAgDomTipo.Name = "cmbAgDomTipo";
            this.cmbAgDomTipo.Size = new System.Drawing.Size(120, 23);
            this.cmbAgDomTipo.TabIndex = 5;
            // 
            // lblAgDomTipo
            // 
            this.lblAgDomTipo.AutoSize = true;
            this.lblAgDomTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgDomTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgDomTipo.Location = new System.Drawing.Point(12, 67);
            this.lblAgDomTipo.Name = "lblAgDomTipo";
            this.lblAgDomTipo.Size = new System.Drawing.Size(34, 15);
            this.lblAgDomTipo.TabIndex = 4;
            this.lblAgDomTipo.Text = "Tipo:";
            // 
            // txtAgDomNumero
            // 
            this.txtAgDomNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgDomNumero.Location = new System.Drawing.Point(280, 39);
            this.txtAgDomNumero.Name = "txtAgDomNumero";
            this.txtAgDomNumero.Size = new System.Drawing.Size(95, 23);
            this.txtAgDomNumero.TabIndex = 3;
            // 
            // lblAgDomNumero
            // 
            this.lblAgDomNumero.AutoSize = true;
            this.lblAgDomNumero.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgDomNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgDomNumero.Location = new System.Drawing.Point(277, 22);
            this.lblAgDomNumero.Name = "lblAgDomNumero";
            this.lblAgDomNumero.Size = new System.Drawing.Size(56, 15);
            this.lblAgDomNumero.TabIndex = 2;
            this.lblAgDomNumero.Text = "Número:";
            // 
            // txtAgDomNombre
            // 
            this.txtAgDomNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgDomNombre.Location = new System.Drawing.Point(15, 39);
            this.txtAgDomNombre.Name = "txtAgDomNombre";
            this.txtAgDomNombre.Size = new System.Drawing.Size(250, 23);
            this.txtAgDomNombre.TabIndex = 1;
            // 
            // lblAgDomNombre
            // 
            this.lblAgDomNombre.AutoSize = true;
            this.lblAgDomNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgDomNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgDomNombre.Location = new System.Drawing.Point(12, 22);
            this.lblAgDomNombre.Name = "lblAgDomNombre";
            this.lblAgDomNombre.Size = new System.Drawing.Size(87, 15);
            this.lblAgDomNombre.TabIndex = 0;
            this.lblAgDomNombre.Text = "Nombre/Calle:";
            // 
            // grpAgContacto
            // 
            this.grpAgContacto.BackColor = System.Drawing.Color.White;
            this.grpAgContacto.Controls.Add(this.txtAgCelular);
            this.grpAgContacto.Controls.Add(this.btnAgRemoveRed);
            this.grpAgContacto.Controls.Add(this.btnAgAddRed);
            this.grpAgContacto.Controls.Add(this.dgvAgRedes);
            this.grpAgContacto.Controls.Add(this.txtAgRedUser);
            this.grpAgContacto.Controls.Add(this.lblAgRedUser);
            this.grpAgContacto.Controls.Add(this.cmbAgRedSocial);
            this.grpAgContacto.Controls.Add(this.lblAgRedSocial);
            this.grpAgContacto.Controls.Add(this.lblAgCelular);
            this.grpAgContacto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpAgContacto.Location = new System.Drawing.Point(375, 20);
            this.grpAgContacto.Name = "grpAgContacto";
            this.grpAgContacto.Size = new System.Drawing.Size(385, 245);
            this.grpAgContacto.TabIndex = 1;
            this.grpAgContacto.TabStop = false;
            this.grpAgContacto.Text = "Contacto";
            // 
            // btnAgRemoveRed
            // 
            this.btnAgRemoveRed.BackColor = System.Drawing.Color.Crimson;
            this.btnAgRemoveRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgRemoveRed.FlatAppearance.BorderSize = 0;
            this.btnAgRemoveRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgRemoveRed.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgRemoveRed.ForeColor = System.Drawing.Color.White;
            this.btnAgRemoveRed.Location = new System.Drawing.Point(280, 213);
            this.btnAgRemoveRed.Name = "btnAgRemoveRed";
            this.btnAgRemoveRed.Size = new System.Drawing.Size(95, 27);
            this.btnAgRemoveRed.TabIndex = 8;
            this.btnAgRemoveRed.Text = "Quitar";
            this.btnAgRemoveRed.UseVisualStyleBackColor = false;
            this.btnAgRemoveRed.Click += new System.EventHandler(this.btnAgRemoveRed_Click);
            // 
            // btnAgAddRed
            // 
            this.btnAgAddRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAgAddRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgAddRed.FlatAppearance.BorderSize = 0;
            this.btnAgAddRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgAddRed.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgAddRed.ForeColor = System.Drawing.Color.White;
            this.btnAgAddRed.Location = new System.Drawing.Point(280, 92);
            this.btnAgAddRed.Name = "btnAgAddRed";
            this.btnAgAddRed.Size = new System.Drawing.Size(75, 23);
            this.btnAgAddRed.TabIndex = 9;
            this.btnAgAddRed.Text = "Añadir";
            this.btnAgAddRed.UseVisualStyleBackColor = false;
            this.btnAgAddRed.Click += new System.EventHandler(this.btnAgAddRed_Click);
            // 
            // dgvAgRedes
            // 
            this.dgvAgRedes.AllowUserToAddRows = false;
            this.dgvAgRedes.AllowUserToDeleteRows = false;
            this.dgvAgRedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgRedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dgvAgRedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgRedes.Location = new System.Drawing.Point(15, 125);
            this.dgvAgRedes.Name = "dgvAgRedes";
            this.dgvAgRedes.ReadOnly = true;
            this.dgvAgRedes.RowHeadersVisible = false;
            this.dgvAgRedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgRedes.Size = new System.Drawing.Size(360, 82);
            this.dgvAgRedes.TabIndex = 6;
            // 
            // txtAgRedUser
            // 
            this.txtAgRedUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgRedUser.Location = new System.Drawing.Point(145, 93);
            this.txtAgRedUser.Name = "txtAgRedUser";
            this.txtAgRedUser.Size = new System.Drawing.Size(120, 23);
            this.txtAgRedUser.TabIndex = 5;
            // 
            // lblAgRedUser
            // 
            this.lblAgRedUser.AutoSize = true;
            this.lblAgRedUser.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgRedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgRedUser.Location = new System.Drawing.Point(142, 75);
            this.lblAgRedUser.Name = "lblAgRedUser";
            this.lblAgRedUser.Size = new System.Drawing.Size(52, 15);
            this.lblAgRedUser.TabIndex = 4;
            this.lblAgRedUser.Text = "Usuario:";
            // 
            // cmbAgRedSocial
            // 
            this.cmbAgRedSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgRedSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgRedSocial.FormattingEnabled = true;
            this.cmbAgRedSocial.Location = new System.Drawing.Point(15, 93);
            this.cmbAgRedSocial.Name = "cmbAgRedSocial";
            this.cmbAgRedSocial.Size = new System.Drawing.Size(110, 23);
            this.cmbAgRedSocial.TabIndex = 3;
            // 
            // lblAgRedSocial
            // 
            this.lblAgRedSocial.AutoSize = true;
            this.lblAgRedSocial.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgRedSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgRedSocial.Location = new System.Drawing.Point(12, 75);
            this.lblAgRedSocial.Name = "lblAgRedSocial";
            this.lblAgRedSocial.Size = new System.Drawing.Size(67, 15);
            this.lblAgRedSocial.TabIndex = 2;
            this.lblAgRedSocial.Text = "Red Social:";
            // 
            // lblAgCelular
            // 
            this.lblAgCelular.AutoSize = true;
            this.lblAgCelular.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgCelular.Location = new System.Drawing.Point(12, 26);
            this.lblAgCelular.Name = "lblAgCelular";
            this.lblAgCelular.Size = new System.Drawing.Size(114, 15);
            this.lblAgCelular.TabIndex = 0;
            this.lblAgCelular.Text = "Número de Celular:";
            // 
            // grpAgPersonales
            // 
            this.grpAgPersonales.BackColor = System.Drawing.Color.White;
            this.grpAgPersonales.Controls.Add(this.cmbAgLocalidad);
            this.grpAgPersonales.Controls.Add(this.lblAgLocalidad);
            this.grpAgPersonales.Controls.Add(this.cmbAgProvincia);
            this.grpAgPersonales.Controls.Add(this.lblAgProvincia);
            this.grpAgPersonales.Controls.Add(this.cmbAgPerfil);
            this.grpAgPersonales.Controls.Add(this.lblAgPerfil);
            this.grpAgPersonales.Controls.Add(this.txtAgMail);
            this.grpAgPersonales.Controls.Add(this.lblAgMail);
            this.grpAgPersonales.Controls.Add(this.txtAgPassword);
            this.grpAgPersonales.Controls.Add(this.lblAgPassword);
            this.grpAgPersonales.Controls.Add(this.txtAgDNI);
            this.grpAgPersonales.Controls.Add(this.lblAgDNI);
            this.grpAgPersonales.Controls.Add(this.txtAgApellido);
            this.grpAgPersonales.Controls.Add(this.lblAgApellido);
            this.grpAgPersonales.Controls.Add(this.txtAgNombre);
            this.grpAgPersonales.Controls.Add(this.lblAgNombre);
            this.grpAgPersonales.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpAgPersonales.Location = new System.Drawing.Point(20, 20);
            this.grpAgPersonales.Name = "grpAgPersonales";
            this.grpAgPersonales.Size = new System.Drawing.Size(340, 495);
            this.grpAgPersonales.TabIndex = 0;
            this.grpAgPersonales.TabStop = false;
            this.grpAgPersonales.Text = "Datos Personales";
            // 
            // cmbAgLocalidad
            // 
            this.cmbAgLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgLocalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgLocalidad.FormattingEnabled = true;
            this.cmbAgLocalidad.Location = new System.Drawing.Point(20, 448);
            this.cmbAgLocalidad.Name = "cmbAgLocalidad";
            this.cmbAgLocalidad.Size = new System.Drawing.Size(300, 23);
            this.cmbAgLocalidad.TabIndex = 15;
            // 
            // lblAgLocalidad
            // 
            this.lblAgLocalidad.AutoSize = true;
            this.lblAgLocalidad.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgLocalidad.Location = new System.Drawing.Point(17, 431);
            this.lblAgLocalidad.Name = "lblAgLocalidad";
            this.lblAgLocalidad.Size = new System.Drawing.Size(118, 15);
            this.lblAgLocalidad.TabIndex = 14;
            this.lblAgLocalidad.Text = "Localidad (Córdoba):";
            // 
            // cmbAgProvincia
            // 
            this.cmbAgProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgProvincia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgProvincia.FormattingEnabled = true;
            this.cmbAgProvincia.Location = new System.Drawing.Point(20, 395);
            this.cmbAgProvincia.Name = "cmbAgProvincia";
            this.cmbAgProvincia.Size = new System.Drawing.Size(300, 23);
            this.cmbAgProvincia.TabIndex = 13;
            // 
            // lblAgProvincia
            // 
            this.lblAgProvincia.AutoSize = true;
            this.lblAgProvincia.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgProvincia.Location = new System.Drawing.Point(17, 378);
            this.lblAgProvincia.Name = "lblAgProvincia";
            this.lblAgProvincia.Size = new System.Drawing.Size(127, 15);
            this.lblAgProvincia.TabIndex = 12;
            this.lblAgProvincia.Text = "Provincia (Argentina):";
            // 
            // cmbAgPerfil
            // 
            this.cmbAgPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgPerfil.FormattingEnabled = true;
            this.cmbAgPerfil.Location = new System.Drawing.Point(20, 340);
            this.cmbAgPerfil.Name = "cmbAgPerfil";
            this.cmbAgPerfil.Size = new System.Drawing.Size(300, 23);
            this.cmbAgPerfil.TabIndex = 11;
            // 
            // lblAgPerfil
            // 
            this.lblAgPerfil.AutoSize = true;
            this.lblAgPerfil.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgPerfil.Location = new System.Drawing.Point(17, 323);
            this.lblAgPerfil.Name = "lblAgPerfil";
            this.lblAgPerfil.Size = new System.Drawing.Size(40, 15);
            this.lblAgPerfil.TabIndex = 10;
            this.lblAgPerfil.Text = "Perfil:";
            // 
            // txtAgMail
            // 
            this.txtAgMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgMail.Location = new System.Drawing.Point(20, 287);
            this.txtAgMail.Name = "txtAgMail";
            this.txtAgMail.Size = new System.Drawing.Size(300, 23);
            this.txtAgMail.TabIndex = 9;
            // 
            // lblAgMail
            // 
            this.lblAgMail.AutoSize = true;
            this.lblAgMail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgMail.Location = new System.Drawing.Point(17, 270);
            this.lblAgMail.Name = "lblAgMail";
            this.lblAgMail.Size = new System.Drawing.Size(45, 15);
            this.lblAgMail.TabIndex = 8;
            this.lblAgMail.Text = "Gmail :";
            // 
            // txtAgPassword
            // 
            this.txtAgPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgPassword.Location = new System.Drawing.Point(20, 234);
            this.txtAgPassword.Name = "txtAgPassword";
            this.txtAgPassword.Size = new System.Drawing.Size(300, 23);
            this.txtAgPassword.TabIndex = 7;
            // 
            // lblAgPassword
            // 
            this.lblAgPassword.AutoSize = true;
            this.lblAgPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgPassword.Location = new System.Drawing.Point(17, 217);
            this.lblAgPassword.Name = "lblAgPassword";
            this.lblAgPassword.Size = new System.Drawing.Size(72, 15);
            this.lblAgPassword.TabIndex = 6;
            this.lblAgPassword.Text = "Contraseña:";
            // 
            // txtAgDNI
            // 
            this.txtAgDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgDNI.Location = new System.Drawing.Point(20, 180);
            this.txtAgDNI.Name = "txtAgDNI";
            this.txtAgDNI.Size = new System.Drawing.Size(300, 23);
            this.txtAgDNI.TabIndex = 5;
            // 
            // lblAgDNI
            // 
            this.lblAgDNI.AutoSize = true;
            this.lblAgDNI.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgDNI.Location = new System.Drawing.Point(17, 163);
            this.lblAgDNI.Name = "lblAgDNI";
            this.lblAgDNI.Size = new System.Drawing.Size(32, 15);
            this.lblAgDNI.TabIndex = 4;
            this.lblAgDNI.Text = "DNI:";
            // 
            // txtAgApellido
            // 
            this.txtAgApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgApellido.Location = new System.Drawing.Point(20, 127);
            this.txtAgApellido.Name = "txtAgApellido";
            this.txtAgApellido.Size = new System.Drawing.Size(300, 23);
            this.txtAgApellido.TabIndex = 3;
            // 
            // lblAgApellido
            // 
            this.lblAgApellido.AutoSize = true;
            this.lblAgApellido.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgApellido.Location = new System.Drawing.Point(17, 110);
            this.lblAgApellido.Name = "lblAgApellido";
            this.lblAgApellido.Size = new System.Drawing.Size(55, 15);
            this.lblAgApellido.TabIndex = 2;
            this.lblAgApellido.Text = "Apellido:";
            // 
            // txtAgNombre
            // 
            this.txtAgNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgNombre.Location = new System.Drawing.Point(20, 74);
            this.txtAgNombre.Name = "txtAgNombre";
            this.txtAgNombre.Size = new System.Drawing.Size(300, 23);
            this.txtAgNombre.TabIndex = 1;
            // 
            // lblAgNombre
            // 
            this.lblAgNombre.AutoSize = true;
            this.lblAgNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblAgNombre.Location = new System.Drawing.Point(17, 57);
            this.lblAgNombre.Name = "lblAgNombre";
            this.lblAgNombre.Size = new System.Drawing.Size(56, 15);
            this.lblAgNombre.TabIndex = 0;
            this.lblAgNombre.Text = "Nombre:";
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.btnEdBaja);
            this.pnlEditar.Controls.Add(this.btnEdGuardar);
            this.pnlEditar.Controls.Add(this.grpEdDomicilios);
            this.pnlEditar.Controls.Add(this.grpEdContacto);
            this.pnlEditar.Controls.Add(this.grpEdNuevosDatos);
            this.pnlEditar.Controls.Add(this.grpEdActuales);
            this.pnlEditar.Controls.Add(this.pnlEdSeleccionar);
            this.pnlEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(780, 590);
            this.pnlEditar.TabIndex = 1;
            // 
            // btnEdBaja
            // 
            this.btnEdBaja.BackColor = System.Drawing.Color.Crimson;
            this.btnEdBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdBaja.FlatAppearance.BorderSize = 0;
            this.btnEdBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdBaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdBaja.ForeColor = System.Drawing.Color.White;
            this.btnEdBaja.Location = new System.Drawing.Point(20, 530);
            this.btnEdBaja.Name = "btnEdBaja";
            this.btnEdBaja.Size = new System.Drawing.Size(150, 40);
            this.btnEdBaja.TabIndex = 6;
            this.btnEdBaja.Text = "Dar de Baja";
            this.btnEdBaja.UseVisualStyleBackColor = false;
            this.btnEdBaja.Click += new System.EventHandler(this.btnEdBaja_Click);
            // 
            // btnEdGuardar
            // 
            this.btnEdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdGuardar.FlatAppearance.BorderSize = 0;
            this.btnEdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdGuardar.ForeColor = System.Drawing.Color.White;
            this.btnEdGuardar.Location = new System.Drawing.Point(610, 530);
            this.btnEdGuardar.Name = "btnEdGuardar";
            this.btnEdGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnEdGuardar.TabIndex = 5;
            this.btnEdGuardar.Text = "Guardar Cambios";
            this.btnEdGuardar.UseVisualStyleBackColor = false;
            this.btnEdGuardar.Click += new System.EventHandler(this.btnEdGuardar_Click);
            // 
            // grpEdDomicilios
            // 
            this.grpEdDomicilios.BackColor = System.Drawing.Color.White;
            this.grpEdDomicilios.Controls.Add(this.btnEdMaps);
            this.grpEdDomicilios.Controls.Add(this.btnEdRemoveDom);
            this.grpEdDomicilios.Controls.Add(this.btnEdAddDom);
            this.grpEdDomicilios.Controls.Add(this.dgvEdDomicilios);
            this.grpEdDomicilios.Controls.Add(this.cmbEdDomTipo);
            this.grpEdDomicilios.Controls.Add(this.lblEdDomTipo);
            this.grpEdDomicilios.Controls.Add(this.txtEdDomNumero);
            this.grpEdDomicilios.Controls.Add(this.lblEdDomNumero);
            this.grpEdDomicilios.Controls.Add(this.txtEdDomNombre);
            this.grpEdDomicilios.Controls.Add(this.lblEdDomNombre);
            this.grpEdDomicilios.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdDomicilios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpEdDomicilios.Location = new System.Drawing.Point(375, 290);
            this.grpEdDomicilios.Name = "grpEdDomicilios";
            this.grpEdDomicilios.Size = new System.Drawing.Size(385, 225);
            this.grpEdDomicilios.TabIndex = 4;
            this.grpEdDomicilios.TabStop = false;
            this.grpEdDomicilios.Text = "Domicilios";
            // 
            // btnEdMaps
            // 
            this.btnEdMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEdMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdMaps.FlatAppearance.BorderSize = 0;
            this.btnEdMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdMaps.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdMaps.ForeColor = System.Drawing.Color.White;
            this.btnEdMaps.Location = new System.Drawing.Point(280, 192);
            this.btnEdMaps.Name = "btnEdMaps";
            this.btnEdMaps.Size = new System.Drawing.Size(95, 25);
            this.btnEdMaps.TabIndex = 9;
            this.btnEdMaps.Text = "Maps";
            this.btnEdMaps.UseVisualStyleBackColor = false;
            this.btnEdMaps.Click += new System.EventHandler(this.btnEdMaps_Click);
            // 
            // btnEdRemoveDom
            // 
            this.btnEdRemoveDom.BackColor = System.Drawing.Color.Crimson;
            this.btnEdRemoveDom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdRemoveDom.FlatAppearance.BorderSize = 0;
            this.btnEdRemoveDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdRemoveDom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdRemoveDom.ForeColor = System.Drawing.Color.White;
            this.btnEdRemoveDom.Location = new System.Drawing.Point(180, 192);
            this.btnEdRemoveDom.Name = "btnEdRemoveDom";
            this.btnEdRemoveDom.Size = new System.Drawing.Size(95, 25);
            this.btnEdRemoveDom.TabIndex = 8;
            this.btnEdRemoveDom.Text = "Quitar";
            this.btnEdRemoveDom.UseVisualStyleBackColor = false;
            this.btnEdRemoveDom.Click += new System.EventHandler(this.btnEdRemoveDom_Click);
            // 
            // btnEdAddDom
            // 
            this.btnEdAddDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEdAddDom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdAddDom.FlatAppearance.BorderSize = 0;
            this.btnEdAddDom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdAddDom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdAddDom.ForeColor = System.Drawing.Color.White;
            this.btnEdAddDom.Location = new System.Drawing.Point(280, 77);
            this.btnEdAddDom.Name = "btnEdAddDom";
            this.btnEdAddDom.Size = new System.Drawing.Size(95, 25);
            this.btnEdAddDom.TabIndex = 7;
            this.btnEdAddDom.Text = "Agregar";
            this.btnEdAddDom.UseVisualStyleBackColor = false;
            this.btnEdAddDom.Click += new System.EventHandler(this.btnEdAddDom_Click);
            // 
            // dgvEdDomicilios
            // 
            this.dgvEdDomicilios.AllowUserToAddRows = false;
            this.dgvEdDomicilios.AllowUserToDeleteRows = false;
            this.dgvEdDomicilios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEdDomicilios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dgvEdDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdDomicilios.Location = new System.Drawing.Point(15, 110);
            this.dgvEdDomicilios.Name = "dgvEdDomicilios";
            this.dgvEdDomicilios.ReadOnly = true;
            this.dgvEdDomicilios.RowHeadersVisible = false;
            this.dgvEdDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdDomicilios.Size = new System.Drawing.Size(360, 78);
            this.dgvEdDomicilios.TabIndex = 6;
            // 
            // cmbEdDomTipo
            // 
            this.cmbEdDomTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdDomTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdDomTipo.FormattingEnabled = true;
            this.cmbEdDomTipo.Location = new System.Drawing.Point(15, 77);
            this.cmbEdDomTipo.Name = "cmbEdDomTipo";
            this.cmbEdDomTipo.Size = new System.Drawing.Size(120, 23);
            this.cmbEdDomTipo.TabIndex = 5;
            // 
            // lblEdDomTipo
            // 
            this.lblEdDomTipo.AutoSize = true;
            this.lblEdDomTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdDomTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdDomTipo.Location = new System.Drawing.Point(12, 60);
            this.lblEdDomTipo.Name = "lblEdDomTipo";
            this.lblEdDomTipo.Size = new System.Drawing.Size(34, 15);
            this.lblEdDomTipo.TabIndex = 4;
            this.lblEdDomTipo.Text = "Tipo:";
            // 
            // txtEdDomNumero
            // 
            this.txtEdDomNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdDomNumero.Location = new System.Drawing.Point(280, 32);
            this.txtEdDomNumero.Name = "txtEdDomNumero";
            this.txtEdDomNumero.Size = new System.Drawing.Size(95, 23);
            this.txtEdDomNumero.TabIndex = 3;
            // 
            // lblEdDomNumero
            // 
            this.lblEdDomNumero.AutoSize = true;
            this.lblEdDomNumero.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdDomNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdDomNumero.Location = new System.Drawing.Point(277, 15);
            this.lblEdDomNumero.Name = "lblEdDomNumero";
            this.lblEdDomNumero.Size = new System.Drawing.Size(56, 15);
            this.lblEdDomNumero.TabIndex = 2;
            this.lblEdDomNumero.Text = "Número:";
            // 
            // txtEdDomNombre
            // 
            this.txtEdDomNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdDomNombre.Location = new System.Drawing.Point(15, 32);
            this.txtEdDomNombre.Name = "txtEdDomNombre";
            this.txtEdDomNombre.Size = new System.Drawing.Size(250, 23);
            this.txtEdDomNombre.TabIndex = 1;
            // 
            // lblEdDomNombre
            // 
            this.lblEdDomNombre.AutoSize = true;
            this.lblEdDomNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdDomNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdDomNombre.Location = new System.Drawing.Point(12, 15);
            this.lblEdDomNombre.Name = "lblEdDomNombre";
            this.lblEdDomNombre.Size = new System.Drawing.Size(87, 15);
            this.lblEdDomNombre.TabIndex = 0;
            this.lblEdDomNombre.Text = "Nombre/Calle:";
            // 
            // grpEdContacto
            // 
            this.grpEdContacto.BackColor = System.Drawing.Color.White;
            this.grpEdContacto.Controls.Add(this.btnEdRemoveRed);
            this.grpEdContacto.Controls.Add(this.btnEdAddRed);
            this.grpEdContacto.Controls.Add(this.dgvEdRedes);
            this.grpEdContacto.Controls.Add(this.txtEdRedUser);
            this.grpEdContacto.Controls.Add(this.lblEdRedUser);
            this.grpEdContacto.Controls.Add(this.cmbEdRedSocial);
            this.grpEdContacto.Controls.Add(this.lblEdRedSocial);
            this.grpEdContacto.Controls.Add(this.txtEdCelular);
            this.grpEdContacto.Controls.Add(this.lblEdCelular);
            this.grpEdContacto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpEdContacto.Location = new System.Drawing.Point(375, 60);
            this.grpEdContacto.Name = "grpEdContacto";
            this.grpEdContacto.Size = new System.Drawing.Size(385, 225);
            this.grpEdContacto.TabIndex = 3;
            this.grpEdContacto.TabStop = false;
            this.grpEdContacto.Text = "Contacto";
            // 
            // btnEdRemoveRed
            // 
            this.btnEdRemoveRed.BackColor = System.Drawing.Color.Crimson;
            this.btnEdRemoveRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdRemoveRed.FlatAppearance.BorderSize = 0;
            this.btnEdRemoveRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdRemoveRed.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdRemoveRed.ForeColor = System.Drawing.Color.White;
            this.btnEdRemoveRed.Location = new System.Drawing.Point(280, 192);
            this.btnEdRemoveRed.Name = "btnEdRemoveRed";
            this.btnEdRemoveRed.Size = new System.Drawing.Size(95, 25);
            this.btnEdRemoveRed.TabIndex = 8;
            this.btnEdRemoveRed.Text = "Quitar";
            this.btnEdRemoveRed.UseVisualStyleBackColor = false;
            this.btnEdRemoveRed.Click += new System.EventHandler(this.btnEdRemoveRed_Click);
            // 
            // btnEdAddRed
            // 
            this.btnEdAddRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnEdAddRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdAddRed.FlatAppearance.BorderSize = 0;
            this.btnEdAddRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdAddRed.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdAddRed.ForeColor = System.Drawing.Color.White;
            this.btnEdAddRed.Location = new System.Drawing.Point(280, 77);
            this.btnEdAddRed.Name = "btnEdAddRed";
            this.btnEdAddRed.Size = new System.Drawing.Size(95, 25);
            this.btnEdAddRed.TabIndex = 7;
            this.btnEdAddRed.Text = "Añadir";
            this.btnEdAddRed.UseVisualStyleBackColor = false;
            this.btnEdAddRed.Click += new System.EventHandler(this.btnEdAddRed_Click);
            // 
            // dgvEdRedes
            // 
            this.dgvEdRedes.AllowUserToAddRows = false;
            this.dgvEdRedes.AllowUserToDeleteRows = false;
            this.dgvEdRedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEdRedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dgvEdRedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdRedes.Location = new System.Drawing.Point(15, 110);
            this.dgvEdRedes.Name = "dgvEdRedes";
            this.dgvEdRedes.ReadOnly = true;
            this.dgvEdRedes.RowHeadersVisible = false;
            this.dgvEdRedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdRedes.Size = new System.Drawing.Size(360, 78);
            this.dgvEdRedes.TabIndex = 6;
            // 
            // txtEdRedUser
            // 
            this.txtEdRedUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdRedUser.Location = new System.Drawing.Point(145, 78);
            this.txtEdRedUser.Name = "txtEdRedUser";
            this.txtEdRedUser.Size = new System.Drawing.Size(120, 23);
            this.txtEdRedUser.TabIndex = 5;
            // 
            // lblEdRedUser
            // 
            this.lblEdRedUser.AutoSize = true;
            this.lblEdRedUser.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdRedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdRedUser.Location = new System.Drawing.Point(142, 60);
            this.lblEdRedUser.Name = "lblEdRedUser";
            this.lblEdRedUser.Size = new System.Drawing.Size(52, 15);
            this.lblEdRedUser.TabIndex = 4;
            this.lblEdRedUser.Text = "Usuario:";
            // 
            // cmbEdRedSocial
            // 
            this.cmbEdRedSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdRedSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdRedSocial.FormattingEnabled = true;
            this.cmbEdRedSocial.Location = new System.Drawing.Point(15, 78);
            this.cmbEdRedSocial.Name = "cmbEdRedSocial";
            this.cmbEdRedSocial.Size = new System.Drawing.Size(110, 23);
            this.cmbEdRedSocial.TabIndex = 3;
            // 
            // lblEdRedSocial
            // 
            this.lblEdRedSocial.AutoSize = true;
            this.lblEdRedSocial.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdRedSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdRedSocial.Location = new System.Drawing.Point(12, 60);
            this.lblEdRedSocial.Name = "lblEdRedSocial";
            this.lblEdRedSocial.Size = new System.Drawing.Size(67, 15);
            this.lblEdRedSocial.TabIndex = 2;
            this.lblEdRedSocial.Text = "Red Social:";
            // 
            // txtEdCelular
            // 
            this.txtEdCelular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdCelular.Location = new System.Drawing.Point(15, 32);
            this.txtEdCelular.Name = "txtEdCelular";
            this.txtEdCelular.Size = new System.Drawing.Size(360, 23);
            this.txtEdCelular.TabIndex = 1;
            // 
            // lblEdCelular
            // 
            this.lblEdCelular.AutoSize = true;
            this.lblEdCelular.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdCelular.Location = new System.Drawing.Point(12, 15);
            this.lblEdCelular.Name = "lblEdCelular";
            this.lblEdCelular.Size = new System.Drawing.Size(114, 15);
            this.lblEdCelular.TabIndex = 0;
            this.lblEdCelular.Text = "Número de Celular:";
            // 
            // grpEdNuevosDatos
            // 
            this.grpEdNuevosDatos.BackColor = System.Drawing.Color.White;
            this.grpEdNuevosDatos.Controls.Add(this.cmbEdPerfil);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdPerfil);
            this.grpEdNuevosDatos.Controls.Add(this.txtEdMail);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdMail);
            this.grpEdNuevosDatos.Controls.Add(this.txtEdPassword);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdPassword);
            this.grpEdNuevosDatos.Controls.Add(this.txtEdDNI);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdDNI);
            this.grpEdNuevosDatos.Controls.Add(this.txtEdApellido);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdApellido);
            this.grpEdNuevosDatos.Controls.Add(this.txtEdNombre);
            this.grpEdNuevosDatos.Controls.Add(this.lblEdNombre);
            this.grpEdNuevosDatos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdNuevosDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.grpEdNuevosDatos.Location = new System.Drawing.Point(20, 275);
            this.grpEdNuevosDatos.Name = "grpEdNuevosDatos";
            this.grpEdNuevosDatos.Size = new System.Drawing.Size(340, 240);
            this.grpEdNuevosDatos.TabIndex = 2;
            this.grpEdNuevosDatos.TabStop = false;
            this.grpEdNuevosDatos.Text = "Nuevos Datos para Reemplazar";
            // 
            // cmbEdPerfil
            // 
            this.cmbEdPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdPerfil.FormattingEnabled = true;
            this.cmbEdPerfil.Location = new System.Drawing.Point(180, 195);
            this.cmbEdPerfil.Name = "cmbEdPerfil";
            this.cmbEdPerfil.Size = new System.Drawing.Size(140, 23);
            this.cmbEdPerfil.TabIndex = 11;
            // 
            // lblEdPerfil
            // 
            this.lblEdPerfil.AutoSize = true;
            this.lblEdPerfil.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdPerfil.Location = new System.Drawing.Point(177, 178);
            this.lblEdPerfil.Name = "lblEdPerfil";
            this.lblEdPerfil.Size = new System.Drawing.Size(40, 15);
            this.lblEdPerfil.TabIndex = 10;
            this.lblEdPerfil.Text = "Perfil:";
            // 
            // txtEdMail
            // 
            this.txtEdMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdMail.Location = new System.Drawing.Point(20, 195);
            this.txtEdMail.Name = "txtEdMail";
            this.txtEdMail.Size = new System.Drawing.Size(140, 23);
            this.txtEdMail.TabIndex = 9;
            // 
            // lblEdMail
            // 
            this.lblEdMail.AutoSize = true;
            this.lblEdMail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdMail.Location = new System.Drawing.Point(17, 178);
            this.lblEdMail.Name = "lblEdMail";
            this.lblEdMail.Size = new System.Drawing.Size(45, 15);
            this.lblEdMail.TabIndex = 8;
            this.lblEdMail.Text = "Gmail :";
            // 
            // txtEdPassword
            // 
            this.txtEdPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdPassword.Location = new System.Drawing.Point(180, 140);
            this.txtEdPassword.Name = "txtEdPassword";
            this.txtEdPassword.Size = new System.Drawing.Size(140, 23);
            this.txtEdPassword.TabIndex = 7;
            // 
            // lblEdPassword
            // 
            this.lblEdPassword.AutoSize = true;
            this.lblEdPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdPassword.Location = new System.Drawing.Point(177, 123);
            this.lblEdPassword.Name = "lblEdPassword";
            this.lblEdPassword.Size = new System.Drawing.Size(72, 15);
            this.lblEdPassword.TabIndex = 6;
            this.lblEdPassword.Text = "Contraseña:";
            // 
            // txtEdDNI
            // 
            this.txtEdDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdDNI.Location = new System.Drawing.Point(20, 140);
            this.txtEdDNI.Name = "txtEdDNI";
            this.txtEdDNI.Size = new System.Drawing.Size(140, 23);
            this.txtEdDNI.TabIndex = 5;
            // 
            // lblEdDNI
            // 
            this.lblEdDNI.AutoSize = true;
            this.lblEdDNI.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdDNI.Location = new System.Drawing.Point(17, 123);
            this.lblEdDNI.Name = "lblEdDNI";
            this.lblEdDNI.Size = new System.Drawing.Size(32, 15);
            this.lblEdDNI.TabIndex = 4;
            this.lblEdDNI.Text = "DNI:";
            // 
            // txtEdApellido
            // 
            this.txtEdApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdApellido.Location = new System.Drawing.Point(180, 85);
            this.txtEdApellido.Name = "txtEdApellido";
            this.txtEdApellido.Size = new System.Drawing.Size(140, 23);
            this.txtEdApellido.TabIndex = 3;
            // 
            // lblEdApellido
            // 
            this.lblEdApellido.AutoSize = true;
            this.lblEdApellido.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdApellido.Location = new System.Drawing.Point(177, 68);
            this.lblEdApellido.Name = "lblEdApellido";
            this.lblEdApellido.Size = new System.Drawing.Size(55, 15);
            this.lblEdApellido.TabIndex = 2;
            this.lblEdApellido.Text = "Apellido:";
            // 
            // txtEdNombre
            // 
            this.txtEdNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdNombre.Location = new System.Drawing.Point(20, 85);
            this.txtEdNombre.Name = "txtEdNombre";
            this.txtEdNombre.Size = new System.Drawing.Size(140, 23);
            this.txtEdNombre.TabIndex = 1;
            // 
            // lblEdNombre
            // 
            this.lblEdNombre.AutoSize = true;
            this.lblEdNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblEdNombre.Location = new System.Drawing.Point(17, 68);
            this.lblEdNombre.Name = "lblEdNombre";
            this.lblEdNombre.Size = new System.Drawing.Size(56, 15);
            this.lblEdNombre.TabIndex = 0;
            this.lblEdNombre.Text = "Nombre:";
            // 
            // grpEdActuales
            // 
            this.grpEdActuales.BackColor = System.Drawing.Color.White;
            this.grpEdActuales.Controls.Add(this.lblEdActPerfilVal);
            this.grpEdActuales.Controls.Add(this.lblEdActMailVal);
            this.grpEdActuales.Controls.Add(this.lblEdActPassVal);
            this.grpEdActuales.Controls.Add(this.lblEdActDNIVal);
            this.grpEdActuales.Controls.Add(this.lblEdActApeVal);
            this.grpEdActuales.Controls.Add(this.lblEdActNomVal);
            this.grpEdActuales.Controls.Add(this.lblEdActPerfil);
            this.grpEdActuales.Controls.Add(this.lblEdActMail);
            this.grpEdActuales.Controls.Add(this.lblEdActPass);
            this.grpEdActuales.Controls.Add(this.lblEdActDNI);
            this.grpEdActuales.Controls.Add(this.lblEdActApe);
            this.grpEdActuales.Controls.Add(this.lblEdActNom);
            this.grpEdActuales.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEdActuales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.grpEdActuales.Location = new System.Drawing.Point(20, 60);
            this.grpEdActuales.Name = "grpEdActuales";
            this.grpEdActuales.Size = new System.Drawing.Size(340, 205);
            this.grpEdActuales.TabIndex = 1;
            this.grpEdActuales.TabStop = false;
            this.grpEdActuales.Text = "Datos Actuales";
            // 
            // lblEdActPerfilVal
            // 
            this.lblEdActPerfilVal.AutoSize = true;
            this.lblEdActPerfilVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActPerfilVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActPerfilVal.Location = new System.Drawing.Point(100, 175);
            this.lblEdActPerfilVal.Name = "lblEdActPerfilVal";
            this.lblEdActPerfilVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActPerfilVal.TabIndex = 11;
            this.lblEdActPerfilVal.Text = "-";
            // 
            // lblEdActMailVal
            // 
            this.lblEdActMailVal.AutoSize = true;
            this.lblEdActMailVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActMailVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActMailVal.Location = new System.Drawing.Point(100, 145);
            this.lblEdActMailVal.Name = "lblEdActMailVal";
            this.lblEdActMailVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActMailVal.TabIndex = 10;
            this.lblEdActMailVal.Text = "-";
            // 
            // lblEdActPassVal
            // 
            this.lblEdActPassVal.AutoSize = true;
            this.lblEdActPassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActPassVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActPassVal.Location = new System.Drawing.Point(100, 115);
            this.lblEdActPassVal.Name = "lblEdActPassVal";
            this.lblEdActPassVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActPassVal.TabIndex = 9;
            this.lblEdActPassVal.Text = "-";
            // 
            // lblEdActDNIVal
            // 
            this.lblEdActDNIVal.AutoSize = true;
            this.lblEdActDNIVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActDNIVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActDNIVal.Location = new System.Drawing.Point(100, 85);
            this.lblEdActDNIVal.Name = "lblEdActDNIVal";
            this.lblEdActDNIVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActDNIVal.TabIndex = 8;
            this.lblEdActDNIVal.Text = "-";
            // 
            // lblEdActApeVal
            // 
            this.lblEdActApeVal.AutoSize = true;
            this.lblEdActApeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActApeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActApeVal.Location = new System.Drawing.Point(100, 55);
            this.lblEdActApeVal.Name = "lblEdActApeVal";
            this.lblEdActApeVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActApeVal.TabIndex = 7;
            this.lblEdActApeVal.Text = "-";
            // 
            // lblEdActNomVal
            // 
            this.lblEdActNomVal.AutoSize = true;
            this.lblEdActNomVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActNomVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdActNomVal.Location = new System.Drawing.Point(100, 25);
            this.lblEdActNomVal.Name = "lblEdActNomVal";
            this.lblEdActNomVal.Size = new System.Drawing.Size(12, 15);
            this.lblEdActNomVal.TabIndex = 6;
            this.lblEdActNomVal.Text = "-";
            // 
            // lblEdActPerfil
            // 
            this.lblEdActPerfil.AutoSize = true;
            this.lblEdActPerfil.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActPerfil.Location = new System.Drawing.Point(15, 175);
            this.lblEdActPerfil.Name = "lblEdActPerfil";
            this.lblEdActPerfil.Size = new System.Drawing.Size(40, 15);
            this.lblEdActPerfil.TabIndex = 5;
            this.lblEdActPerfil.Text = "Perfil:";
            // 
            // lblEdActMail
            // 
            this.lblEdActMail.AutoSize = true;
            this.lblEdActMail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActMail.Location = new System.Drawing.Point(15, 145);
            this.lblEdActMail.Name = "lblEdActMail";
            this.lblEdActMail.Size = new System.Drawing.Size(45, 15);
            this.lblEdActMail.TabIndex = 4;
            this.lblEdActMail.Text = "Gmail :";
            // 
            // lblEdActPass
            // 
            this.lblEdActPass.AutoSize = true;
            this.lblEdActPass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActPass.Location = new System.Drawing.Point(15, 115);
            this.lblEdActPass.Name = "lblEdActPass";
            this.lblEdActPass.Size = new System.Drawing.Size(72, 15);
            this.lblEdActPass.TabIndex = 3;
            this.lblEdActPass.Text = "Contraseña:";
            // 
            // lblEdActDNI
            // 
            this.lblEdActDNI.AutoSize = true;
            this.lblEdActDNI.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActDNI.Location = new System.Drawing.Point(15, 85);
            this.lblEdActDNI.Name = "lblEdActDNI";
            this.lblEdActDNI.Size = new System.Drawing.Size(32, 15);
            this.lblEdActDNI.TabIndex = 2;
            this.lblEdActDNI.Text = "DNI:";
            // 
            // lblEdActApe
            // 
            this.lblEdActApe.AutoSize = true;
            this.lblEdActApe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActApe.Location = new System.Drawing.Point(15, 55);
            this.lblEdActApe.Name = "lblEdActApe";
            this.lblEdActApe.Size = new System.Drawing.Size(55, 15);
            this.lblEdActApe.TabIndex = 1;
            this.lblEdActApe.Text = "Apellido:";
            // 
            // lblEdActNom
            // 
            this.lblEdActNom.AutoSize = true;
            this.lblEdActNom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdActNom.Location = new System.Drawing.Point(15, 25);
            this.lblEdActNom.Name = "lblEdActNom";
            this.lblEdActNom.Size = new System.Drawing.Size(56, 15);
            this.lblEdActNom.TabIndex = 0;
            this.lblEdActNom.Text = "Nombre:";
            // 
            // pnlEdSeleccionar
            // 
            this.pnlEdSeleccionar.BackColor = System.Drawing.Color.White;
            this.pnlEdSeleccionar.Controls.Add(this.cmbEdSeleccionar);
            this.pnlEdSeleccionar.Controls.Add(this.lblEdSeleccionar);
            this.pnlEdSeleccionar.Location = new System.Drawing.Point(20, 10);
            this.pnlEdSeleccionar.Name = "pnlEdSeleccionar";
            this.pnlEdSeleccionar.Size = new System.Drawing.Size(740, 45);
            this.pnlEdSeleccionar.TabIndex = 0;
            // 
            // cmbEdSeleccionar
            // 
            this.cmbEdSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdSeleccionar.FormattingEnabled = true;
            this.cmbEdSeleccionar.Location = new System.Drawing.Point(160, 10);
            this.cmbEdSeleccionar.Name = "cmbEdSeleccionar";
            this.cmbEdSeleccionar.Size = new System.Drawing.Size(560, 23);
            this.cmbEdSeleccionar.TabIndex = 1;
            this.cmbEdSeleccionar.SelectedIndexChanged += new System.EventHandler(this.cmbEdSeleccionar_SelectedIndexChanged);
            // 
            // lblEdSeleccionar
            // 
            this.lblEdSeleccionar.AutoSize = true;
            this.lblEdSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblEdSeleccionar.Location = new System.Drawing.Point(15, 12);
            this.lblEdSeleccionar.Name = "lblEdSeleccionar";
            this.lblEdSeleccionar.Size = new System.Drawing.Size(132, 17);
            this.lblEdSeleccionar.TabIndex = 0;
            this.lblEdSeleccionar.Text = "Seleccionar Usuario:";
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.Controls.Add(this.dgvAuditoria);
            this.pnlAuditoria.Controls.Add(this.pnlAuditoriaHeader);
            this.pnlAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuditoria.Location = new System.Drawing.Point(0, 0);
            this.pnlAuditoria.Name = "pnlAuditoria";
            this.pnlAuditoria.Size = new System.Drawing.Size(780, 590);
            this.pnlAuditoria.TabIndex = 2;
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditoria.Location = new System.Drawing.Point(0, 50);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditoria.Size = new System.Drawing.Size(780, 540);
            this.dgvAuditoria.TabIndex = 1;
            // 
            // pnlAuditoriaHeader
            // 
            this.pnlAuditoriaHeader.BackColor = System.Drawing.Color.White;
            this.pnlAuditoriaHeader.Controls.Add(this.btnAudRefrescar);
            this.pnlAuditoriaHeader.Controls.Add(this.lblAudTitle);
            this.pnlAuditoriaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuditoriaHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAuditoriaHeader.Name = "pnlAuditoriaHeader";
            this.pnlAuditoriaHeader.Size = new System.Drawing.Size(780, 50);
            this.pnlAuditoriaHeader.TabIndex = 0;
            // 
            // btnAudRefrescar
            // 
            this.btnAudRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnAudRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudRefrescar.FlatAppearance.BorderSize = 0;
            this.btnAudRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnAudRefrescar.Location = new System.Drawing.Point(650, 10);
            this.btnAudRefrescar.Name = "btnAudRefrescar";
            this.btnAudRefrescar.Size = new System.Drawing.Size(110, 30);
            this.btnAudRefrescar.TabIndex = 1;
            this.btnAudRefrescar.Text = "Actualizar";
            this.btnAudRefrescar.UseVisualStyleBackColor = false;
            this.btnAudRefrescar.Click += new System.EventHandler(this.btnAudRefrescar_Click);
            // 
            // lblAudTitle
            // 
            this.lblAudTitle.AutoSize = true;
            this.lblAudTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblAudTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAudTitle.Name = "lblAudTitle";
            this.lblAudTitle.Size = new System.Drawing.Size(231, 20);
            this.lblAudTitle.TabIndex = 0;
            this.lblAudTitle.Text = "Auditoría de Accesos al Sistema";
            // 
            // pnlEstadoConex
            // 
            this.pnlEstadoConex.Controls.Add(this.pnlConCard);
            this.pnlEstadoConex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadoConex.Location = new System.Drawing.Point(0, 0);
            this.pnlEstadoConex.Name = "pnlEstadoConex";
            this.pnlEstadoConex.Size = new System.Drawing.Size(780, 590);
            this.pnlEstadoConex.TabIndex = 3;
            // 
            // pnlConCard
            // 
            this.pnlConCard.BackColor = System.Drawing.Color.White;
            this.pnlConCard.Controls.Add(this.btnConReconectar);
            this.pnlConCard.Controls.Add(this.lblConDetails);
            this.pnlConCard.Controls.Add(this.lblConStatus);
            this.pnlConCard.Controls.Add(this.pnlConStatusIndicator);
            this.pnlConCard.Location = new System.Drawing.Point(140, 95);
            this.pnlConCard.Name = "pnlConCard";
            this.pnlConCard.Size = new System.Drawing.Size(500, 400);
            this.pnlConCard.TabIndex = 0;
            // 
            // btnConReconectar
            // 
            this.btnConReconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnConReconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConReconectar.FlatAppearance.BorderSize = 0;
            this.btnConReconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConReconectar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConReconectar.ForeColor = System.Drawing.Color.White;
            this.btnConReconectar.Location = new System.Drawing.Point(150, 310);
            this.btnConReconectar.Name = "btnConReconectar";
            this.btnConReconectar.Size = new System.Drawing.Size(200, 45);
            this.btnConReconectar.TabIndex = 3;
            this.btnConReconectar.Text = "Reconectar";
            this.btnConReconectar.UseVisualStyleBackColor = false;
            this.btnConReconectar.Click += new System.EventHandler(this.btnConReconectar_Click);
            // 
            // lblConDetails
            // 
            this.lblConDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.lblConDetails.Location = new System.Drawing.Point(20, 200);
            this.lblConDetails.Name = "lblConDetails";
            this.lblConDetails.Size = new System.Drawing.Size(460, 90);
            this.lblConDetails.TabIndex = 2;
            this.lblConDetails.Text = "Última comprobación: -\r\nBase de datos: Access (Aybar1.accdb)\r\nProveedor: Microsof" +
    "t.ACE.OLEDB.12.0";
            this.lblConDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConStatus
            // 
            this.lblConStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblConStatus.Location = new System.Drawing.Point(20, 140);
            this.lblConStatus.Name = "lblConStatus";
            this.lblConStatus.Size = new System.Drawing.Size(460, 40);
            this.lblConStatus.TabIndex = 1;
            this.lblConStatus.Text = "Estado: Verificando...";
            this.lblConStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlConStatusIndicator
            // 
            this.pnlConStatusIndicator.BackColor = System.Drawing.Color.Gray;
            this.pnlConStatusIndicator.Location = new System.Drawing.Point(200, 30);
            this.pnlConStatusIndicator.Name = "pnlConStatusIndicator";
            this.pnlConStatusIndicator.Size = new System.Drawing.Size(100, 100);
            this.pnlConStatusIndicator.TabIndex = 0;
            this.pnlConStatusIndicator.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConStatusIndicator_Paint);
            // 
            // txtAgCelular
            // 
            this.txtAgCelular.Location = new System.Drawing.Point(15, 45);
            this.txtAgCelular.Mask = "000-000-0000";
            this.txtAgCelular.Name = "txtAgCelular";
            this.txtAgCelular.Size = new System.Drawing.Size(360, 24);
            this.txtAgCelular.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aybar ERP - Sistema de Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlAgregar.ResumeLayout(false);
            this.grpAgDomicilios.ResumeLayout(false);
            this.grpAgDomicilios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgDomicilios)).EndInit();
            this.grpAgContacto.ResumeLayout(false);
            this.grpAgContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgRedes)).EndInit();
            this.grpAgPersonales.ResumeLayout(false);
            this.grpAgPersonales.PerformLayout();
            this.pnlEditar.ResumeLayout(false);
            this.grpEdDomicilios.ResumeLayout(false);
            this.grpEdDomicilios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdDomicilios)).EndInit();
            this.grpEdContacto.ResumeLayout(false);
            this.grpEdContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdRedes)).EndInit();
            this.grpEdNuevosDatos.ResumeLayout(false);
            this.grpEdNuevosDatos.PerformLayout();
            this.grpEdActuales.ResumeLayout(false);
            this.grpEdActuales.PerformLayout();
            this.pnlEdSeleccionar.ResumeLayout(false);
            this.pnlEdSeleccionar.PerformLayout();
            this.pnlAuditoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.pnlAuditoriaHeader.ResumeLayout(false);
            this.pnlAuditoriaHeader.PerformLayout();
            this.pnlEstadoConex.ResumeLayout(false);
            this.pnlConCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Button btnNavAgregar;
        private System.Windows.Forms.Button btnNavEditar;
        private System.Windows.Forms.Button btnNavAuditoria;
        private System.Windows.Forms.Button btnNavEstadoConex;
        private System.Windows.Forms.Button btnNavSalir;
        private System.Windows.Forms.Button btnNavCerrarSesion;
        private System.Windows.Forms.Panel pnlSessionDivider;
        private System.Windows.Forms.Label lblSessionPerfil;
        private System.Windows.Forms.Label lblSessionUser;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Panel pnlAuditoria;
        private System.Windows.Forms.Panel pnlEstadoConex;
        private System.Windows.Forms.GroupBox grpAgPersonales;
        private System.Windows.Forms.Label lblAgNombre;
        private System.Windows.Forms.TextBox txtAgNombre;
        private System.Windows.Forms.Label lblAgApellido;
        private System.Windows.Forms.TextBox txtAgApellido;
        private System.Windows.Forms.Label lblAgDNI;
        private System.Windows.Forms.TextBox txtAgDNI;
        private System.Windows.Forms.Label lblAgPassword;
        private System.Windows.Forms.TextBox txtAgPassword;
        private System.Windows.Forms.Label lblAgMail;
        private System.Windows.Forms.TextBox txtAgMail;
        private System.Windows.Forms.Label lblAgPerfil;
        private System.Windows.Forms.ComboBox cmbAgPerfil;
        private System.Windows.Forms.Label lblAgProvincia;
        private System.Windows.Forms.ComboBox cmbAgProvincia;
        private System.Windows.Forms.Label lblAgLocalidad;
        private System.Windows.Forms.ComboBox cmbAgLocalidad;
        private System.Windows.Forms.GroupBox grpAgContacto;
        private System.Windows.Forms.Label lblAgCelular;
        private System.Windows.Forms.Label lblAgRedSocial;
        private System.Windows.Forms.ComboBox cmbAgRedSocial;
        private System.Windows.Forms.Label lblAgRedUser;
        private System.Windows.Forms.TextBox txtAgRedUser;
        private System.Windows.Forms.Button btnAgAddRed;
        private System.Windows.Forms.DataGridView dgvAgRedes;
        private System.Windows.Forms.Button btnAgRemoveRed;
        private System.Windows.Forms.GroupBox grpAgDomicilios;
        private System.Windows.Forms.Label lblAgDomNombre;
        private System.Windows.Forms.TextBox txtAgDomNombre;
        private System.Windows.Forms.Label lblAgDomNumero;
        private System.Windows.Forms.TextBox txtAgDomNumero;
        private System.Windows.Forms.Label lblAgDomTipo;
        private System.Windows.Forms.ComboBox cmbAgDomTipo;
        private System.Windows.Forms.Button btnAgAddDom;
        private System.Windows.Forms.DataGridView dgvAgDomicilios;
        private System.Windows.Forms.Button btnAgRemoveDom;
        private System.Windows.Forms.Button btnAgMaps;
        private System.Windows.Forms.Button btnAgGuardar;
        private System.Windows.Forms.Button btnAgLimpiar;
        private System.Windows.Forms.Panel pnlEdSeleccionar;
        private System.Windows.Forms.Label lblEdSeleccionar;
        private System.Windows.Forms.ComboBox cmbEdSeleccionar;
        private System.Windows.Forms.GroupBox grpEdActuales;
        private System.Windows.Forms.Label lblEdActNom;
        private System.Windows.Forms.Label lblEdActNomVal;
        private System.Windows.Forms.Label lblEdActApe;
        private System.Windows.Forms.Label lblEdActApeVal;
        private System.Windows.Forms.Label lblEdActDNI;
        private System.Windows.Forms.Label lblEdActDNIVal;
        private System.Windows.Forms.Label lblEdActPass;
        private System.Windows.Forms.Label lblEdActPassVal;
        private System.Windows.Forms.Label lblEdActMail;
        private System.Windows.Forms.Label lblEdActMailVal;
        private System.Windows.Forms.Label lblEdActPerfil;
        private System.Windows.Forms.Label lblEdActPerfilVal;
        private System.Windows.Forms.GroupBox grpEdNuevosDatos;
        private System.Windows.Forms.Label lblEdNombre;
        private System.Windows.Forms.TextBox txtEdNombre;
        private System.Windows.Forms.Label lblEdApellido;
        private System.Windows.Forms.TextBox txtEdApellido;
        private System.Windows.Forms.Label lblEdDNI;
        private System.Windows.Forms.TextBox txtEdDNI;
        private System.Windows.Forms.Label lblEdPassword;
        private System.Windows.Forms.TextBox txtEdPassword;
        private System.Windows.Forms.Label lblEdMail;
        private System.Windows.Forms.TextBox txtEdMail;
        private System.Windows.Forms.Label lblEdPerfil;
        private System.Windows.Forms.ComboBox cmbEdPerfil;
        private System.Windows.Forms.GroupBox grpEdContacto;
        private System.Windows.Forms.Label lblEdCelular;
        private System.Windows.Forms.TextBox txtEdCelular;
        private System.Windows.Forms.Label lblEdRedSocial;
        private System.Windows.Forms.ComboBox cmbEdRedSocial;
        private System.Windows.Forms.Label lblEdRedUser;
        private System.Windows.Forms.TextBox txtEdRedUser;
        private System.Windows.Forms.Button btnEdAddRed;
        private System.Windows.Forms.DataGridView dgvEdRedes;
        private System.Windows.Forms.Button btnEdRemoveRed;
        private System.Windows.Forms.GroupBox grpEdDomicilios;
        private System.Windows.Forms.Label lblEdDomNombre;
        private System.Windows.Forms.TextBox txtEdDomNombre;
        private System.Windows.Forms.Label lblEdDomNumero;
        private System.Windows.Forms.TextBox txtEdDomNumero;
        private System.Windows.Forms.Label lblEdDomTipo;
        private System.Windows.Forms.ComboBox cmbEdDomTipo;
        private System.Windows.Forms.Button btnEdAddDom;
        private System.Windows.Forms.DataGridView dgvEdDomicilios;
        private System.Windows.Forms.Button btnEdRemoveDom;
        private System.Windows.Forms.Button btnEdMaps;
        private System.Windows.Forms.Button btnEdGuardar;
        private System.Windows.Forms.Button btnEdBaja;
        private System.Windows.Forms.Panel pnlAuditoriaHeader;
        private System.Windows.Forms.Label lblAudTitle;
        private System.Windows.Forms.Button btnAudRefrescar;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Panel pnlConCard;
        private System.Windows.Forms.Panel pnlConStatusIndicator;
        private System.Windows.Forms.Label lblConStatus;
        private System.Windows.Forms.Label lblConDetails;
        private System.Windows.Forms.Button btnConReconectar;
        private System.Windows.Forms.MaskedTextBox txtAgCelular;
    }
}
