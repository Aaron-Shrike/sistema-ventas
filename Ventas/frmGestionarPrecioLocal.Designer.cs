namespace Ventas
{
    partial class frmGestionarPrecioLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPrecioLocal));
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudExonerado = new System.Windows.Forms.NumericUpDown();
            this.nudIGV = new System.Windows.Forms.NumericUpDown();
            this.nudISC = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblExonerado = new MetroFramework.Controls.MetroLabel();
            this.lblIGV = new MetroFramework.Controls.MetroLabel();
            this.lblISC = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioMinimo = new MetroFramework.Controls.MetroLabel();
            this.cboNombreProducto = new MetroFramework.Controls.MetroComboBox();
            this.lblNombreProducto = new MetroFramework.Controls.MetroLabel();
            this.cboTipoISC = new MetroFramework.Controls.MetroComboBox();
            this.cboNombreLocal = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.lblTipoISC = new MetroFramework.Controls.MetroLabel();
            this.lblNombreLocal = new MetroFramework.Controls.MetroLabel();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbEntidad = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdNombreLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExonerado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
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
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(126, 270);
            this.nudStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(264, 22);
            this.nudStock.TabIndex = 17;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStock.Validating += new System.ComponentModel.CancelEventHandler(this.nudStock_Validating);
            // 
            // nudExonerado
            // 
            this.nudExonerado.Location = new System.Drawing.Point(126, 237);
            this.nudExonerado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudExonerado.Name = "nudExonerado";
            this.nudExonerado.Size = new System.Drawing.Size(264, 22);
            this.nudExonerado.TabIndex = 15;
            this.nudExonerado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudIGV
            // 
            this.nudIGV.Location = new System.Drawing.Point(126, 207);
            this.nudIGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudIGV.Name = "nudIGV";
            this.nudIGV.Size = new System.Drawing.Size(264, 22);
            this.nudIGV.TabIndex = 13;
            this.nudIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIGV.Validating += new System.ComponentModel.CancelEventHandler(this.nudIGV_Validating);
            // 
            // nudISC
            // 
            this.nudISC.Location = new System.Drawing.Point(126, 177);
            this.nudISC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudISC.Name = "nudISC";
            this.nudISC.Size = new System.Drawing.Size(264, 22);
            this.nudISC.TabIndex = 11;
            this.nudISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudISC.Validating += new System.ComponentModel.CancelEventHandler(this.nudISC_Validating);
            // 
            // nudPrecioMinimo
            // 
            this.nudPrecioMinimo.Location = new System.Drawing.Point(126, 112);
            this.nudPrecioMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrecioMinimo.Name = "nudPrecioMinimo";
            this.nudPrecioMinimo.Size = new System.Drawing.Size(264, 22);
            this.nudPrecioMinimo.TabIndex = 7;
            this.nudPrecioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecioMinimo.Validating += new System.ComponentModel.CancelEventHandler(this.nudPrecioMinimo_Validating);
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(126, 82);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(264, 22);
            this.nudPrecio.TabIndex = 5;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.nudPrecio_Validating);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.CustomBackground = true;
            this.lblStock.Location = new System.Drawing.Point(24, 271);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(40, 19);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stoc&k";
            // 
            // lblExonerado
            // 
            this.lblExonerado.AutoSize = true;
            this.lblExonerado.CustomBackground = true;
            this.lblExonerado.Location = new System.Drawing.Point(24, 238);
            this.lblExonerado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExonerado.Name = "lblExonerado";
            this.lblExonerado.Size = new System.Drawing.Size(72, 19);
            this.lblExonerado.TabIndex = 14;
            this.lblExonerado.Text = "E&xonerado";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.CustomBackground = true;
            this.lblIGV.Location = new System.Drawing.Point(24, 208);
            this.lblIGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(29, 19);
            this.lblIGV.TabIndex = 12;
            this.lblIGV.Text = "I&GV";
            // 
            // lblISC
            // 
            this.lblISC.AutoSize = true;
            this.lblISC.CustomBackground = true;
            this.lblISC.Location = new System.Drawing.Point(24, 178);
            this.lblISC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISC.Name = "lblISC";
            this.lblISC.Size = new System.Drawing.Size(28, 19);
            this.lblISC.TabIndex = 10;
            this.lblISC.Text = "I&SC";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.CustomBackground = true;
            this.lblPrecio.Location = new System.Drawing.Point(24, 83);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "P&recio";
            // 
            // lblPrecioMinimo
            // 
            this.lblPrecioMinimo.AutoSize = true;
            this.lblPrecioMinimo.CustomBackground = true;
            this.lblPrecioMinimo.Location = new System.Drawing.Point(24, 113);
            this.lblPrecioMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMinimo.Name = "lblPrecioMinimo";
            this.lblPrecioMinimo.Size = new System.Drawing.Size(95, 19);
            this.lblPrecioMinimo.TabIndex = 6;
            this.lblPrecioMinimo.Text = "Preci&o Mínimo";
            // 
            // cboNombreProducto
            // 
            this.cboNombreProducto.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboNombreProducto.FormattingEnabled = true;
            this.cboNombreProducto.ItemHeight = 19;
            this.cboNombreProducto.Location = new System.Drawing.Point(126, 49);
            this.cboNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboNombreProducto.Name = "cboNombreProducto";
            this.cboNombreProducto.Size = new System.Drawing.Size(264, 25);
            this.cboNombreProducto.TabIndex = 3;
            this.cboNombreProducto.Validating += new System.ComponentModel.CancelEventHandler(this.cboNombreProducto_Validating);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.CustomBackground = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(24, 52);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(63, 19);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "&Producto";
            // 
            // cboTipoISC
            // 
            this.cboTipoISC.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboTipoISC.FormattingEnabled = true;
            this.cboTipoISC.ItemHeight = 19;
            this.cboTipoISC.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoISC.Location = new System.Drawing.Point(126, 142);
            this.cboTipoISC.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoISC.Name = "cboTipoISC";
            this.cboTipoISC.Size = new System.Drawing.Size(264, 25);
            this.cboTipoISC.TabIndex = 9;
            this.cboTipoISC.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoISC_Validating);
            // 
            // cboNombreLocal
            // 
            this.cboNombreLocal.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboNombreLocal.FormattingEnabled = true;
            this.cboNombreLocal.ItemHeight = 19;
            this.cboNombreLocal.Location = new System.Drawing.Point(126, 16);
            this.cboNombreLocal.Margin = new System.Windows.Forms.Padding(4);
            this.cboNombreLocal.Name = "cboNombreLocal";
            this.cboNombreLocal.Size = new System.Drawing.Size(264, 25);
            this.cboNombreLocal.TabIndex = 1;
            this.cboNombreLocal.Validating += new System.ComponentModel.CancelEventHandler(this.cboNombreLocal_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(294, 354);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(96, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(184, 354);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 32);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(24, 311);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(61, 15);
            this.chkVigente.TabIndex = 18;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // lblTipoISC
            // 
            this.lblTipoISC.AutoSize = true;
            this.lblTipoISC.CustomBackground = true;
            this.lblTipoISC.Location = new System.Drawing.Point(24, 145);
            this.lblTipoISC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoISC.Name = "lblTipoISC";
            this.lblTipoISC.Size = new System.Drawing.Size(58, 19);
            this.lblTipoISC.TabIndex = 8;
            this.lblTipoISC.Text = "&Tipo ISC";
            // 
            // lblNombreLocal
            // 
            this.lblNombreLocal.AutoSize = true;
            this.lblNombreLocal.CustomBackground = true;
            this.lblNombreLocal.Location = new System.Drawing.Point(24, 19);
            this.lblNombreLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLocal.Name = "lblNombreLocal";
            this.lblNombreLocal.Size = new System.Drawing.Size(39, 19);
            this.lblNombreLocal.TabIndex = 0;
            this.lblNombreLocal.Text = "&Local";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(340, 16);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 34);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "&Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(117, 309);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.gbEntidad.Panel.Controls.Add(this.nudStock);
            this.gbEntidad.Panel.Controls.Add(this.nudExonerado);
            this.gbEntidad.Panel.Controls.Add(this.nudIGV);
            this.gbEntidad.Panel.Controls.Add(this.nudISC);
            this.gbEntidad.Panel.Controls.Add(this.nudPrecioMinimo);
            this.gbEntidad.Panel.Controls.Add(this.nudPrecio);
            this.gbEntidad.Panel.Controls.Add(this.lblStock);
            this.gbEntidad.Panel.Controls.Add(this.lblExonerado);
            this.gbEntidad.Panel.Controls.Add(this.lblIGV);
            this.gbEntidad.Panel.Controls.Add(this.lblISC);
            this.gbEntidad.Panel.Controls.Add(this.lblPrecio);
            this.gbEntidad.Panel.Controls.Add(this.lblPrecioMinimo);
            this.gbEntidad.Panel.Controls.Add(this.cboNombreProducto);
            this.gbEntidad.Panel.Controls.Add(this.lblNombreProducto);
            this.gbEntidad.Panel.Controls.Add(this.cboTipoISC);
            this.gbEntidad.Panel.Controls.Add(this.cboNombreLocal);
            this.gbEntidad.Panel.Controls.Add(this.btnCancelar);
            this.gbEntidad.Panel.Controls.Add(this.btnAceptar);
            this.gbEntidad.Panel.Controls.Add(this.chkVigente);
            this.gbEntidad.Panel.Controls.Add(this.lblTipoISC);
            this.gbEntidad.Panel.Controls.Add(this.lblNombreLocal);
            this.gbEntidad.Size = new System.Drawing.Size(433, 423);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.Values.Heading = "Precio local";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(799, 403);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(125, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "C&errar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(17, 309);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(457, 15);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(467, 380);
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
            this.cdNombreLocal,
            this.cdNombreProducto,
            this.cdPrecio});
            this.dgvListado.Location = new System.Drawing.Point(17, 68);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(433, 220);
            this.dgvListado.TabIndex = 1;
            // 
            // cdNombreLocal
            // 
            this.cdNombreLocal.DataPropertyName = "NombreLocal";
            this.cdNombreLocal.HeaderText = "Nombre Local";
            this.cdNombreLocal.Name = "cdNombreLocal";
            this.cdNombreLocal.ReadOnly = true;
            this.cdNombreLocal.Width = 200;
            // 
            // cdNombreProducto
            // 
            this.cdNombreProducto.DataPropertyName = "NombreProducto";
            this.cdNombreProducto.HeaderText = "Nombre Producto";
            this.cdNombreProducto.Name = "cdNombreProducto";
            this.cdNombreProducto.ReadOnly = true;
            this.cdNombreProducto.Width = 150;
            // 
            // cdPrecio
            // 
            this.cdPrecio.DataPropertyName = "Precio";
            this.cdPrecio.HeaderText = "Precio";
            this.cdPrecio.Name = "cdPrecio";
            this.cdPrecio.ReadOnly = true;
            this.cdPrecio.Width = 150;
            // 
            // frmGestionarPrecioLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(931, 447);
            this.Controls.Add(this.gbEntidad);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionarPrecioLocal";
            this.Text = "Gestión del precio de local";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrecioLocal_FormClosed);
            this.Load += new System.EventHandler(this.frmGestionarPrecioLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExonerado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudISC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.NumericUpDown nudExonerado;
        private System.Windows.Forms.NumericUpDown nudIGV;
        private System.Windows.Forms.NumericUpDown nudISC;
        private System.Windows.Forms.NumericUpDown nudPrecioMinimo;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblExonerado;
        private MetroFramework.Controls.MetroLabel lblIGV;
        private MetroFramework.Controls.MetroLabel lblISC;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroLabel lblPrecioMinimo;
        private MetroFramework.Controls.MetroComboBox cboNombreProducto;
        private MetroFramework.Controls.MetroLabel lblNombreProducto;
        private MetroFramework.Controls.MetroComboBox cboTipoISC;
        private MetroFramework.Controls.MetroComboBox cboNombreLocal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
        private MetroFramework.Controls.MetroCheckBox chkVigente;
        private MetroFramework.Controls.MetroLabel lblTipoISC;
        private MetroFramework.Controls.MetroLabel lblNombreLocal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombreLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPrecio;
    }
}