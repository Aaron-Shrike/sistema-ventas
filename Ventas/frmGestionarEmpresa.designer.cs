namespace Ventas
{
    partial class frmGestionarEmpresa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarEmpresa));
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbEmpresa = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblVigencia = new MetroFramework.Controls.MetroLabel();
            this.txtLogo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtInstagram = new MetroFramework.Controls.MetroTextBox();
            this.lblInstagram = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtWhastapp = new MetroFramework.Controls.MetroTextBox();
            this.lblWhatsApp = new MetroFramework.Controls.MetroLabel();
            this.txtYoutube = new MetroFramework.Controls.MetroTextBox();
            this.lblYoutube = new MetroFramework.Controls.MetroLabel();
            this.txtFacebook = new MetroFramework.Controls.MetroTextBox();
            this.txtRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.txtRUC = new MetroFramework.Controls.MetroTextBox();
            this.lblRazonSocial = new MetroFramework.Controls.MetroLabel();
            this.lblRUC = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.lblFacebook = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).BeginInit();
            this.gbListado.Panel.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEmpresa.Panel)).BeginInit();
            this.gbEmpresa.Panel.SuspendLayout();
            this.gbEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(791, 416);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(124, 33);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "C&errar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(465, 15);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(450, 393);
            this.gbListado.TabIndex = 2;
            this.gbListado.Values.Heading = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdRUC,
            this.cdRazonSocial,
            this.cdCorreo});
            this.dgvListado.Location = new System.Drawing.Point(17, 61);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(411, 239);
            this.dgvListado.TabIndex = 1;
            // 
            // cdRUC
            // 
            this.cdRUC.DataPropertyName = "RUC";
            this.cdRUC.HeaderText = "RUC";
            this.cdRUC.Name = "cdRUC";
            this.cdRUC.ReadOnly = true;
            this.cdRUC.Width = 140;
            // 
            // cdRazonSocial
            // 
            this.cdRazonSocial.DataPropertyName = "RazonSocial";
            this.cdRazonSocial.HeaderText = "Razón Social";
            this.cdRazonSocial.Name = "cdRazonSocial";
            this.cdRazonSocial.ReadOnly = true;
            this.cdRazonSocial.Width = 200;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "Correo";
            this.cdCorreo.HeaderText = "Correo";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            this.cdCorreo.Width = 200;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(315, 19);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 31);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "&Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(139, 323);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 31);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(17, 323);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 31);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbEmpresa.Enabled = false;
            this.gbEmpresa.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbEmpresa.Location = new System.Drawing.Point(16, 15);
            this.gbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmpresa.Name = "gbEmpresa";
            // 
            // gbEmpresa.Panel
            // 
            this.gbEmpresa.Panel.Controls.Add(this.lblVigencia);
            this.gbEmpresa.Panel.Controls.Add(this.txtLogo);
            this.gbEmpresa.Panel.Controls.Add(this.metroLabel1);
            this.gbEmpresa.Panel.Controls.Add(this.txtInstagram);
            this.gbEmpresa.Panel.Controls.Add(this.lblInstagram);
            this.gbEmpresa.Panel.Controls.Add(this.txtCorreo);
            this.gbEmpresa.Panel.Controls.Add(this.metroLabel3);
            this.gbEmpresa.Panel.Controls.Add(this.txtWhastapp);
            this.gbEmpresa.Panel.Controls.Add(this.lblWhatsApp);
            this.gbEmpresa.Panel.Controls.Add(this.txtYoutube);
            this.gbEmpresa.Panel.Controls.Add(this.lblYoutube);
            this.gbEmpresa.Panel.Controls.Add(this.txtFacebook);
            this.gbEmpresa.Panel.Controls.Add(this.txtRazonSocial);
            this.gbEmpresa.Panel.Controls.Add(this.txtRUC);
            this.gbEmpresa.Panel.Controls.Add(this.lblRazonSocial);
            this.gbEmpresa.Panel.Controls.Add(this.lblRUC);
            this.gbEmpresa.Panel.Controls.Add(this.btnCancelar);
            this.gbEmpresa.Panel.Controls.Add(this.btnAceptar);
            this.gbEmpresa.Panel.Controls.Add(this.chkVigente);
            this.gbEmpresa.Panel.Controls.Add(this.lblFacebook);
            this.gbEmpresa.Size = new System.Drawing.Size(441, 436);
            this.gbEmpresa.TabIndex = 1;
            this.gbEmpresa.Values.Heading = "Empresa";
            // 
            // lblVigencia
            // 
            this.lblVigencia.AutoSize = true;
            this.lblVigencia.CustomBackground = true;
            this.lblVigencia.Location = new System.Drawing.Point(23, 325);
            this.lblVigencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(61, 19);
            this.lblVigencia.TabIndex = 16;
            this.lblVigencia.Text = "&Vigencia:";
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLogo.CustomBackground = true;
            this.txtLogo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLogo.Location = new System.Drawing.Point(117, 279);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogo.MaxLength = 100;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(285, 28);
            this.txtLogo.TabIndex = 15;
            this.txtLogo.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogo_Validating);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 285);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "&Logo:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtInstagram.CustomBackground = true;
            this.txtInstagram.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInstagram.Location = new System.Drawing.Point(117, 127);
            this.txtInstagram.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstagram.MaxLength = 100;
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(285, 28);
            this.txtInstagram.TabIndex = 7;
            this.txtInstagram.Validating += new System.ComponentModel.CancelEventHandler(this.txtInstagram_Validating);
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.CustomBackground = true;
            this.lblInstagram.Location = new System.Drawing.Point(23, 133);
            this.lblInstagram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(70, 19);
            this.lblInstagram.TabIndex = 6;
            this.lblInstagram.Text = "In&stagram:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCorreo.CustomBackground = true;
            this.txtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorreo.Location = new System.Drawing.Point(117, 243);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(285, 28);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 249);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "C&orreo:";
            // 
            // txtWhastapp
            // 
            this.txtWhastapp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtWhastapp.CustomBackground = true;
            this.txtWhastapp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWhastapp.Location = new System.Drawing.Point(117, 202);
            this.txtWhastapp.Margin = new System.Windows.Forms.Padding(4);
            this.txtWhastapp.MaxLength = 9;
            this.txtWhastapp.Name = "txtWhastapp";
            this.txtWhastapp.Size = new System.Drawing.Size(285, 28);
            this.txtWhastapp.TabIndex = 11;
            this.txtWhastapp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhastapp_KeyPress);
            this.txtWhastapp.Validating += new System.ComponentModel.CancelEventHandler(this.txtWhastapp_Validating);
            // 
            // lblWhatsApp
            // 
            this.lblWhatsApp.AutoSize = true;
            this.lblWhatsApp.CustomBackground = true;
            this.lblWhatsApp.Location = new System.Drawing.Point(23, 208);
            this.lblWhatsApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhatsApp.Name = "lblWhatsApp";
            this.lblWhatsApp.Size = new System.Drawing.Size(73, 19);
            this.lblWhatsApp.TabIndex = 10;
            this.lblWhatsApp.Text = "&WhatsApp:";
            // 
            // txtYoutube
            // 
            this.txtYoutube.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtYoutube.CustomBackground = true;
            this.txtYoutube.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtYoutube.Location = new System.Drawing.Point(117, 163);
            this.txtYoutube.Margin = new System.Windows.Forms.Padding(4);
            this.txtYoutube.MaxLength = 100;
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(285, 28);
            this.txtYoutube.TabIndex = 9;
            this.txtYoutube.Validating += new System.ComponentModel.CancelEventHandler(this.txtYoutube_Validating);
            // 
            // lblYoutube
            // 
            this.lblYoutube.AutoSize = true;
            this.lblYoutube.CustomBackground = true;
            this.lblYoutube.Location = new System.Drawing.Point(23, 169);
            this.lblYoutube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYoutube.Name = "lblYoutube";
            this.lblYoutube.Size = new System.Drawing.Size(61, 19);
            this.lblYoutube.TabIndex = 8;
            this.lblYoutube.Text = "&Youtube:";
            // 
            // txtFacebook
            // 
            this.txtFacebook.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFacebook.CustomBackground = true;
            this.txtFacebook.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFacebook.Location = new System.Drawing.Point(117, 91);
            this.txtFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacebook.MaxLength = 100;
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(285, 28);
            this.txtFacebook.TabIndex = 5;
            this.txtFacebook.Validating += new System.ComponentModel.CancelEventHandler(this.txtFacebook_Validating);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRazonSocial.CustomBackground = true;
            this.txtRazonSocial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRazonSocial.Location = new System.Drawing.Point(117, 19);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(285, 28);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazonSocial_Validating);
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRUC.CustomBackground = true;
            this.txtRUC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRUC.Location = new System.Drawing.Point(117, 55);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(285, 28);
            this.txtRUC.TabIndex = 3;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtRUC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRUC_Validating);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.CustomBackground = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(23, 25);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(86, 19);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "&Razón Social:";
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.CustomBackground = true;
            this.lblRUC.Location = new System.Drawing.Point(23, 61);
            this.lblRUC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(38, 19);
            this.lblRUC.TabIndex = 2;
            this.lblRUC.Text = "R&UC:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 364);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(123, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(157, 364);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 34);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(117, 328);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(61, 15);
            this.chkVigente.TabIndex = 17;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.CustomBackground = true;
            this.lblFacebook.Location = new System.Drawing.Point(23, 97);
            this.lblFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(69, 19);
            this.lblFacebook.TabIndex = 4;
            this.lblFacebook.Text = "&Facebook:";
            // 
            // frmGestionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(929, 464);
            this.Controls.Add(this.gbEmpresa);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionarEmpresa";
            this.Text = "Gestión de empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestionarEmpresa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).EndInit();
            this.gbListado.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).EndInit();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEmpresa.Panel)).EndInit();
            this.gbEmpresa.Panel.ResumeLayout(false);
            this.gbEmpresa.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbEmpresa)).EndInit();
            this.gbEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errError;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbEmpresa;
        private MetroFramework.Controls.MetroLabel lblRazonSocial;
        private MetroFramework.Controls.MetroLabel lblRUC;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
        private MetroFramework.Controls.MetroCheckBox chkVigente;
        private MetroFramework.Controls.MetroLabel lblFacebook;
        private MetroFramework.Controls.MetroTextBox txtRazonSocial;
        private MetroFramework.Controls.MetroTextBox txtRUC;
        private MetroFramework.Controls.MetroTextBox txtInstagram;
        private MetroFramework.Controls.MetroLabel lblInstagram;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtWhastapp;
        private MetroFramework.Controls.MetroLabel lblWhatsApp;
        private MetroFramework.Controls.MetroTextBox txtYoutube;
        private MetroFramework.Controls.MetroLabel lblYoutube;
        private MetroFramework.Controls.MetroTextBox txtFacebook;
        private MetroFramework.Controls.MetroTextBox txtLogo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblVigencia;
    }
}

