namespace Ventas
{
    partial class frmGestionarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarMarca));
            this.errErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEntidad = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errErrorProvider)).BeginInit();
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
            // errErrorProvider
            // 
            this.errErrorProvider.ContainerControl = this;
            // 
            // gbEntidad
            // 
            this.gbEntidad.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbEntidad.Enabled = false;
            this.gbEntidad.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbEntidad.Location = new System.Drawing.Point(16, 15);
            this.gbEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.gbEntidad.Name = "gbEntidad";
            // 
            // gbEntidad.Panel
            // 
            this.gbEntidad.Panel.Controls.Add(this.txtNombre);
            this.gbEntidad.Panel.Controls.Add(this.lblNombre);
            this.gbEntidad.Panel.Controls.Add(this.btnCancelar);
            this.gbEntidad.Panel.Controls.Add(this.btnAceptar);
            this.gbEntidad.Panel.Controls.Add(this.txtDescripcion);
            this.gbEntidad.Panel.Controls.Add(this.lblVigencia);
            this.gbEntidad.Panel.Controls.Add(this.chkVigente);
            this.gbEntidad.Panel.Controls.Add(this.lblDescripcion);
            this.gbEntidad.Size = new System.Drawing.Size(375, 349);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.Values.Heading = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.CustomBackground = true;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Location = new System.Drawing.Point(106, 16);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 28);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "N&ombre ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(98, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(133, 281);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 80);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(313, 123);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblVigencia
            // 
            this.lblVigencia.AutoSize = true;
            this.lblVigencia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVigencia.Location = new System.Drawing.Point(21, 227);
            this.lblVigencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(56, 15);
            this.lblVigencia.TabIndex = 4;
            this.lblVigencia.Text = "&Vigencia";
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(106, 228);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(61, 15);
            this.chkVigente.TabIndex = 5;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.CustomBackground = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 57);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "&Descripción";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(399, 15);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(532, 304);
            this.gbListado.TabIndex = 1;
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
            this.cdNombre,
            this.cdVigente});
            this.dgvListado.Location = new System.Drawing.Point(17, 71);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(493, 143);
            this.dgvListado.TabIndex = 1;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombre";
            this.cdNombre.HeaderText = "Nombre";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            this.cdNombre.Width = 400;
            // 
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            this.cdVigente.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(395, 16);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(115, 34);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "&Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(121, 230);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(17, 230);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 34);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(812, 327);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(119, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "C&errar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGestionarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(944, 373);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEntidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionarMarca";
            this.Text = "Gestión de marca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestionarMarca_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errErrorProvider)).EndInit();
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

        private System.Windows.Forms.ErrorProvider errErrorProvider;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbEntidad;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
        private System.Windows.Forms.Label lblVigencia;
        private MetroFramework.Controls.MetroCheckBox chkVigente;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdVigente;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}

