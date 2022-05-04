namespace Ventas
{
    partial class frmPersonal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEntidad = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCorreo = new MetroFramework.Controls.MetroLabel();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.lblCelular = new MetroFramework.Controls.MetroLabel();
            this.lblDNI = new MetroFramework.Controls.MetroLabel();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.lblNombres = new MetroFramework.Controls.MetroLabel();
            this.txtDNI = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoMaterno = new MetroFramework.Controls.MetroTextBox();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.txtCelular = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidoPaterno = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad.Panel)).BeginInit();
            this.gbEntidad.Panel.SuspendLayout();
            this.gbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).BeginInit();
            this.gbListado.Panel.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // gbEntidad
            // 
            this.gbEntidad.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbEntidad.Enabled = false;
            this.gbEntidad.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbEntidad.Location = new System.Drawing.Point(12, 15);
            this.gbEntidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEntidad.Name = "gbEntidad";
            // 
            // gbEntidad.Panel
            // 
            this.gbEntidad.Panel.Controls.Add(this.dtpFechaNacimiento);
            this.gbEntidad.Panel.Controls.Add(this.lblCorreo);
            this.gbEntidad.Panel.Controls.Add(this.lblFechaNac);
            this.gbEntidad.Panel.Controls.Add(this.lblCelular);
            this.gbEntidad.Panel.Controls.Add(this.lblDNI);
            this.gbEntidad.Panel.Controls.Add(this.lblApellidos);
            this.gbEntidad.Panel.Controls.Add(this.txtNombres);
            this.gbEntidad.Panel.Controls.Add(this.lblNombres);
            this.gbEntidad.Panel.Controls.Add(this.txtDNI);
            this.gbEntidad.Panel.Controls.Add(this.txtApellidoMaterno);
            this.gbEntidad.Panel.Controls.Add(this.txtCorreo);
            this.gbEntidad.Panel.Controls.Add(this.txtCelular);
            this.gbEntidad.Panel.Controls.Add(this.txtApellidoPaterno);
            this.gbEntidad.Panel.Controls.Add(this.btnCancelar);
            this.gbEntidad.Panel.Controls.Add(this.btnAceptar);
            this.gbEntidad.Panel.Controls.Add(this.chkVigente);
            this.gbEntidad.Size = new System.Drawing.Size(530, 318);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.Values.Heading = "Personal";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(104, 142);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.CustomBackground = true;
            this.lblCorreo.Location = new System.Drawing.Point(25, 173);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 19);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "C&orreo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.CustomBackground = true;
            this.lblFechaNac.Location = new System.Drawing.Point(25, 142);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(73, 19);
            this.lblFechaNac.TabIndex = 9;
            this.lblFechaNac.Text = "&Fecha Nac.";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.CustomBackground = true;
            this.lblCelular.Location = new System.Drawing.Point(25, 111);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 19);
            this.lblCelular.TabIndex = 7;
            this.lblCelular.Text = "Ce&lular";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.CustomBackground = true;
            this.lblDNI.Location = new System.Drawing.Point(25, 18);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 19);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "&DNI";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.CustomBackground = true;
            this.lblApellidos.Location = new System.Drawing.Point(25, 80);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 19);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "A&pellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombres.CustomBackground = true;
            this.txtNombres.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombres.Location = new System.Drawing.Point(104, 47);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(181, 23);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombres_Validating);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.CustomBackground = true;
            this.lblNombres.Location = new System.Drawing.Point(25, 49);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(64, 19);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "&Nombres";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDNI.CustomBackground = true;
            this.txtDNI.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDNI.Location = new System.Drawing.Point(104, 16);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.MaxLength = 100;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(181, 23);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtDNI_Validating);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtApellidoMaterno.CustomBackground = true;
            this.txtApellidoMaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(312, 78);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.MaxLength = 100;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(181, 23);
            this.txtApellidoMaterno.TabIndex = 6;
            this.txtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoMaterno_Validating);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCorreo.CustomBackground = true;
            this.txtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorreo.Location = new System.Drawing.Point(104, 171);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(389, 23);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCelular.CustomBackground = true;
            this.txtCelular.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCelular.Location = new System.Drawing.Point(104, 109);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.MaxLength = 100;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(181, 23);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelular_Validating);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtApellidoPaterno.CustomBackground = true;
            this.txtApellidoPaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(104, 78);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.MaxLength = 100;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(181, 23);
            this.txtApellidoPaterno.TabIndex = 5;
            this.txtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoPaterno_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 254);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(293, 254);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 30);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(29, 206);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(69, 19);
            this.chkVigente.TabIndex = 13;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(548, 15);
            this.gbListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(328, 370);
            this.gbListado.TabIndex = 1;
            this.gbListado.Values.Heading = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdPersonal,
            this.cdCelular,
            this.cdCorreo});
            this.dgvListado.Location = new System.Drawing.Point(13, 66);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(297, 221);
            this.dgvListado.TabIndex = 1;
            // 
            // cdPersonal
            // 
            this.cdPersonal.DataPropertyName = "NombreCompleto";
            this.cdPersonal.HeaderText = "Personal";
            this.cdPersonal.Name = "cdPersonal";
            this.cdPersonal.ReadOnly = true;
            this.cdPersonal.Width = 200;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "Celular";
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "Correo";
            this.cdCorreo.HeaderText = "Correo";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            this.cdCorreo.Width = 150;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(197, 18);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 31);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(105, 303);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 31);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(13, 303);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 31);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(782, 389);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(94, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(888, 431);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEntidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.Text = "Gestión de personal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad.Panel)).EndInit();
            this.gbEntidad.Panel.ResumeLayout(false);
            this.gbEntidad.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad)).EndInit();
            this.gbEntidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).EndInit();
            this.gbListado.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).EndInit();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errError;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbEntidad;
        private MetroFramework.Controls.MetroLabel lblCelular;
        private MetroFramework.Controls.MetroLabel lblDNI;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroTextBox txtCelular;
        private MetroFramework.Controls.MetroTextBox txtApellidoPaterno;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
        private MetroFramework.Controls.MetroCheckBox chkVigente;
        private MetroFramework.Controls.MetroLabel lblCorreo;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroTextBox txtDNI;
        private MetroFramework.Controls.MetroTextBox txtApellidoMaterno;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
    }
}

