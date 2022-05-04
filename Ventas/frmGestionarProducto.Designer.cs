namespace Ventas
{
    partial class frmGestionarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarProducto));
            this.gbEntidad = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.cboTipoControl = new MetroFramework.Controls.MetroComboBox();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.cboMarca = new MetroFramework.Controls.MetroComboBox();
            this.cboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkNegociable = new MetroFramework.Controls.MetroCheckBox();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.lblTipoControl = new MetroFramework.Controls.MetroLabel();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad.Panel)).BeginInit();
            this.gbEntidad.Panel.SuspendLayout();
            this.gbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).BeginInit();
            this.gbListado.Panel.SuspendLayout();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
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
            this.gbEntidad.Panel.Controls.Add(this.cboTipoControl);
            this.gbEntidad.Panel.Controls.Add(this.cboTipo);
            this.gbEntidad.Panel.Controls.Add(this.cboMarca);
            this.gbEntidad.Panel.Controls.Add(this.cboCategoria);
            this.gbEntidad.Panel.Controls.Add(this.btnCancelar);
            this.gbEntidad.Panel.Controls.Add(this.btnAceptar);
            this.gbEntidad.Panel.Controls.Add(this.chkNegociable);
            this.gbEntidad.Panel.Controls.Add(this.chkVigente);
            this.gbEntidad.Panel.Controls.Add(this.lblTipoControl);
            this.gbEntidad.Panel.Controls.Add(this.lblTipo);
            this.gbEntidad.Panel.Controls.Add(this.lblMarca);
            this.gbEntidad.Panel.Controls.Add(this.lblCategoria);
            this.gbEntidad.Panel.Controls.Add(this.lblNombre);
            this.gbEntidad.Size = new System.Drawing.Size(428, 353);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.Values.Heading = "Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.CustomBackground = true;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Location = new System.Drawing.Point(126, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 28);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // cboTipoControl
            // 
            this.cboTipoControl.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboTipoControl.FormattingEnabled = true;
            this.cboTipoControl.ItemHeight = 19;
            this.cboTipoControl.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoControl.Location = new System.Drawing.Point(126, 168);
            this.cboTipoControl.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoControl.Name = "cboTipoControl";
            this.cboTipoControl.Size = new System.Drawing.Size(153, 25);
            this.cboTipoControl.TabIndex = 9;
            this.cboTipoControl.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoControl_Validating);
            // 
            // cboTipo
            // 
            this.cboTipo.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 19;
            this.cboTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipo.Location = new System.Drawing.Point(126, 131);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(153, 25);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipo_Validating);
            // 
            // cboMarca
            // 
            this.cboMarca.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.ItemHeight = 19;
            this.cboMarca.Location = new System.Drawing.Point(126, 94);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(264, 25);
            this.cboMarca.TabIndex = 5;
            this.cboMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cboMarca_Validating);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.ItemHeight = 19;
            this.cboCategoria.Location = new System.Drawing.Point(126, 57);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(264, 25);
            this.cboCategoria.TabIndex = 3;
            this.cboCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.cboCategoria_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 284);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(97, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(190, 284);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 33);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkNegociable
            // 
            this.chkNegociable.AutoSize = true;
            this.chkNegociable.CustomBackground = true;
            this.chkNegociable.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkNegociable.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkNegociable.Location = new System.Drawing.Point(24, 209);
            this.chkNegociable.Margin = new System.Windows.Forms.Padding(4);
            this.chkNegociable.Name = "chkNegociable";
            this.chkNegociable.Size = new System.Drawing.Size(92, 19);
            this.chkNegociable.TabIndex = 10;
            this.chkNegociable.Text = "Negocia&ble";
            this.chkNegociable.UseVisualStyleBackColor = true;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(24, 246);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(69, 19);
            this.chkVigente.TabIndex = 11;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // lblTipoControl
            // 
            this.lblTipoControl.AutoSize = true;
            this.lblTipoControl.CustomBackground = true;
            this.lblTipoControl.Location = new System.Drawing.Point(19, 174);
            this.lblTipoControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoControl.Name = "lblTipoControl";
            this.lblTipoControl.Size = new System.Drawing.Size(99, 19);
            this.lblTipoControl.TabIndex = 8;
            this.lblTipoControl.Text = "Tipo &de control";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.CustomBackground = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 135);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "&Tipo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.CustomBackground = true;
            this.lblMarca.Location = new System.Drawing.Point(19, 98);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Ma&rca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.CustomBackground = true;
            this.lblCategoria.Location = new System.Drawing.Point(19, 61);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Cate&goría";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 21);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "N&ombre";
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
            this.cdNombre,
            this.cdCategoria,
            this.cdMarca});
            this.dgvListado.Location = new System.Drawing.Point(17, 70);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(418, 146);
            this.dgvListado.TabIndex = 1;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombre";
            this.cdNombre.HeaderText = "Nombre";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            this.cdNombre.Width = 200;
            // 
            // cdCategoria
            // 
            this.cdCategoria.DataPropertyName = "NombreCategoria";
            this.cdCategoria.HeaderText = "Categoria";
            this.cdCategoria.Name = "cdCategoria";
            this.cdCategoria.ReadOnly = true;
            this.cdCategoria.Width = 150;
            // 
            // cdMarca
            // 
            this.cdMarca.DataPropertyName = "NombreMarca";
            this.cdMarca.HeaderText = "Marca";
            this.cdMarca.Name = "cdMarca";
            this.cdMarca.ReadOnly = true;
            this.cdMarca.Width = 150;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(801, 334);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(103, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "C&errar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(452, 19);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(452, 307);
            this.gbListado.TabIndex = 3;
            this.gbListado.Values.Heading = "Listado";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(325, 16);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 36);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "&Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(117, 236);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "&Modificar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(17, 236);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "&Nuevo";
            // 
            // frmGestionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(917, 380);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEntidad);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionarProducto";
            this.Text = "Gestión de producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducto_FormClosed);
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad.Panel)).EndInit();
            this.gbEntidad.Panel.ResumeLayout(false);
            this.gbEntidad.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbEntidad)).EndInit();
            this.gbEntidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).EndInit();
            this.gbListado.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbEntidad;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblTipoControl;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroCheckBox chkNegociable;
        private MetroFramework.Controls.MetroCheckBox chkVigente;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroComboBox cboMarca;
        private MetroFramework.Controls.MetroComboBox cboCategoria;
        private MetroFramework.Controls.MetroComboBox cboTipoControl;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private System.Windows.Forms.ErrorProvider errError;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMarca;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;




    }
}