namespace Ventas
{
    partial class frmReporteProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProductos));
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cboMarca = new MetroFramework.Controls.MetroComboBox();
            this.cboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNegociable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnListar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cboEmpresa = new MetroFramework.Controls.MetroComboBox();
            this.lblEmpresa = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLimpiar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).BeginInit();
            this.gbListado.Panel.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbListado.Enabled = false;
            this.gbListado.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCommand;
            this.gbListado.Location = new System.Drawing.Point(13, 96);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.cboMarca);
            this.gbListado.Panel.Controls.Add(this.cboCategoria);
            this.gbListado.Panel.Controls.Add(this.lblMarca);
            this.gbListado.Panel.Controls.Add(this.lblCategoria);
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Size = new System.Drawing.Size(819, 319);
            this.gbListado.TabIndex = 2;
            this.gbListado.Values.Heading = "Listado";
            // 
            // cboMarca
            // 
            this.cboMarca.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.ItemHeight = 19;
            this.cboMarca.Location = new System.Drawing.Point(241, 58);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(264, 25);
            this.cboMarca.TabIndex = 9;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.ItemHeight = 19;
            this.cboCategoria.Location = new System.Drawing.Point(241, 21);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(264, 25);
            this.cboCategoria.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.CustomBackground = true;
            this.lblMarca.Location = new System.Drawing.Point(134, 61);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "&Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.CustomBackground = true;
            this.lblCategoria.Location = new System.Drawing.Point(134, 24);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "C&ategoría";
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
            this.cdMarca,
            this.cdNegociable});
            this.dgvListado.Location = new System.Drawing.Point(17, 123);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(780, 155);
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
            // cdNegociable
            // 
            this.cdNegociable.DataPropertyName = "Negociable";
            this.cdNegociable.HeaderText = "Negociable";
            this.cdNegociable.Name = "cdNegociable";
            this.cdNegociable.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(698, 25);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 33);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "&Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(713, 423);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(119, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "&Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEmpresa.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.ItemHeight = 19;
            this.cboEmpresa.Location = new System.Drawing.Point(235, 46);
            this.cboEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(284, 25);
            this.cboEmpresa.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.CustomBackground = true;
            this.lblEmpresa.Location = new System.Drawing.Point(135, 49);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(60, 19);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "&Empresa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(527, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 31);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Values.Image")));
            this.btnBuscar.Values.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(624, 42);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 31);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Values.Image")));
            this.btnLimpiar.Values.Text = "Lim&piar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(845, 468);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporteProductos";
            this.Text = "Listar Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReporteProductos_FormClosed);
            this.Load += new System.EventHandler(this.frmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbListado.Panel)).EndInit();
            this.gbListado.Panel.ResumeLayout(false);
            this.gbListado.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbListado)).EndInit();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private MetroFramework.Controls.MetroComboBox cboMarca;
        private MetroFramework.Controls.MetroComboBox cboCategoria;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroComboBox cboEmpresa;
        private MetroFramework.Controls.MetroLabel lblEmpresa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMarca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdNegociable;

    }
}