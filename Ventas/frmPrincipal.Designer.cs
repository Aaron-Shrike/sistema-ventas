namespace Ventas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cintaOpciones = new System.Windows.Forms.Ribbon();
            this.rtDatos = new System.Windows.Forms.RibbonTab();
            this.rpPersonal = new System.Windows.Forms.RibbonPanel();
            this.rbPersonal = new System.Windows.Forms.RibbonButton();
            this.rpUsuario = new System.Windows.Forms.RibbonPanel();
            this.rbUsuario = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbSalir = new System.Windows.Forms.RibbonButton();
            this.rtGestion = new System.Windows.Forms.RibbonTab();
            this.rpGestionarEmpresa = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarEmpresa = new System.Windows.Forms.RibbonButton();
            this.rbGestionarLocal = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarLocal = new System.Windows.Forms.RibbonButton();
            this.rbGestionarPrecioLocal = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarPrecioLocal = new System.Windows.Forms.RibbonButton();
            this.rbGestionarCategoria = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarCategoria = new System.Windows.Forms.RibbonButton();
            this.rbGestionarMarca = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarMarca = new System.Windows.Forms.RibbonButton();
            this.rbGestionarProducto = new System.Windows.Forms.RibbonPanel();
            this.btnGestionarProducto = new System.Windows.Forms.RibbonButton();
            this.rtReportes = new System.Windows.Forms.RibbonTab();
            this.rpListadoProductos = new System.Windows.Forms.RibbonPanel();
            this.rbListadoProductos = new System.Windows.Forms.RibbonButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // cintaOpciones
            // 
            this.cintaOpciones.BackColor = System.Drawing.SystemColors.Control;
            this.cintaOpciones.CaptionBarVisible = false;
            this.cintaOpciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cintaOpciones.Location = new System.Drawing.Point(0, 0);
            this.cintaOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cintaOpciones.Minimized = false;
            this.cintaOpciones.Name = "cintaOpciones";
            // 
            // 
            // 
            this.cintaOpciones.OrbDropDown.BorderRoundness = 8;
            this.cintaOpciones.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.cintaOpciones.OrbDropDown.Name = "";
            this.cintaOpciones.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.cintaOpciones.OrbDropDown.TabIndex = 0;
            this.cintaOpciones.OrbVisible = false;
            this.cintaOpciones.RibbonTabFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cintaOpciones.Size = new System.Drawing.Size(915, 111);
            this.cintaOpciones.TabIndex = 1;
            this.cintaOpciones.Tabs.Add(this.rtDatos);
            this.cintaOpciones.Tabs.Add(this.rtGestion);
            this.cintaOpciones.Tabs.Add(this.rtReportes);
            this.cintaOpciones.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.cintaOpciones.Text = "ribbon1";
            // 
            // rtDatos
            // 
            this.rtDatos.Name = "rtDatos";
            this.rtDatos.Panels.Add(this.rpPersonal);
            this.rtDatos.Panels.Add(this.rpUsuario);
            this.rtDatos.Panels.Add(this.ribbonPanel3);
            this.rtDatos.Panels.Add(this.ribbonPanel1);
            this.rtDatos.Text = "Datos";
            // 
            // rpPersonal
            // 
            this.rpPersonal.ButtonMoreVisible = false;
            this.rpPersonal.Items.Add(this.rbPersonal);
            this.rpPersonal.Name = "rpPersonal";
            this.rpPersonal.Text = "Personal";
            this.rpPersonal.Click += new System.EventHandler(this.rbPersonal_Click);
            // 
            // rbPersonal
            // 
            this.rbPersonal.Image = ((System.Drawing.Image)(resources.GetObject("rbPersonal.Image")));
            this.rbPersonal.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbPersonal.LargeImage")));
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbPersonal.SmallImage")));
            this.rbPersonal.Text = "";
            this.rbPersonal.Click += new System.EventHandler(this.rbPersonal_Click);
            // 
            // rpUsuario
            // 
            this.rpUsuario.ButtonMoreVisible = false;
            this.rpUsuario.Items.Add(this.rbUsuario);
            this.rpUsuario.Name = "rpUsuario";
            this.rpUsuario.Text = "Usuario";
            this.rpUsuario.Click += new System.EventHandler(this.rbUsuario_Click);
            // 
            // rbUsuario
            // 
            this.rbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("rbUsuario.Image")));
            this.rbUsuario.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbUsuario.LargeImage")));
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbUsuario.SmallImage")));
            this.rbUsuario.Text = "";
            this.rbUsuario.Click += new System.EventHandler(this.rbUsuario_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.ribbonSeparator1);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.rbSalir);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Salir";
            this.ribbonPanel1.Click += new System.EventHandler(this.rbSalir_Click);
            // 
            // rbSalir
            // 
            this.rbSalir.Image = ((System.Drawing.Image)(resources.GetObject("rbSalir.Image")));
            this.rbSalir.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbSalir.LargeImage")));
            this.rbSalir.Name = "rbSalir";
            this.rbSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbSalir.SmallImage")));
            this.rbSalir.Text = "";
            this.rbSalir.Click += new System.EventHandler(this.rbSalir_Click);
            // 
            // rtGestion
            // 
            this.rtGestion.Name = "rtGestion";
            this.rtGestion.Panels.Add(this.rpGestionarEmpresa);
            this.rtGestion.Panels.Add(this.rbGestionarLocal);
            this.rtGestion.Panels.Add(this.rbGestionarPrecioLocal);
            this.rtGestion.Panels.Add(this.rbGestionarCategoria);
            this.rtGestion.Panels.Add(this.rbGestionarMarca);
            this.rtGestion.Panels.Add(this.rbGestionarProducto);
            this.rtGestion.Text = "Gestión";
            // 
            // rpGestionarEmpresa
            // 
            this.rpGestionarEmpresa.ButtonMoreEnabled = false;
            this.rpGestionarEmpresa.ButtonMoreVisible = false;
            this.rpGestionarEmpresa.Items.Add(this.btnGestionarEmpresa);
            this.rpGestionarEmpresa.Name = "rpGestionarEmpresa";
            this.rpGestionarEmpresa.Text = "Empresa";
            this.rpGestionarEmpresa.Click += new System.EventHandler(this.mnuiEmpresa_Click);
            // 
            // btnGestionarEmpresa
            // 
            this.btnGestionarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarEmpresa.Image")));
            this.btnGestionarEmpresa.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarEmpresa.LargeImage")));
            this.btnGestionarEmpresa.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnGestionarEmpresa.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.btnGestionarEmpresa.Name = "btnGestionarEmpresa";
            this.btnGestionarEmpresa.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarEmpresa.SmallImage")));
            this.btnGestionarEmpresa.Text = "";
            this.btnGestionarEmpresa.Click += new System.EventHandler(this.mnuiEmpresa_Click);
            // 
            // rbGestionarLocal
            // 
            this.rbGestionarLocal.ButtonMoreVisible = false;
            this.rbGestionarLocal.Items.Add(this.btnGestionarLocal);
            this.rbGestionarLocal.Name = "rbGestionarLocal";
            this.rbGestionarLocal.Text = "Local";
            this.rbGestionarLocal.Click += new System.EventHandler(this.mnuiLocal_Click);
            // 
            // btnGestionarLocal
            // 
            this.btnGestionarLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarLocal.Image")));
            this.btnGestionarLocal.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarLocal.LargeImage")));
            this.btnGestionarLocal.Name = "btnGestionarLocal";
            this.btnGestionarLocal.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarLocal.SmallImage")));
            this.btnGestionarLocal.Text = "";
            this.btnGestionarLocal.Click += new System.EventHandler(this.mnuiLocal_Click);
            // 
            // rbGestionarPrecioLocal
            // 
            this.rbGestionarPrecioLocal.ButtonMoreVisible = false;
            this.rbGestionarPrecioLocal.Items.Add(this.btnGestionarPrecioLocal);
            this.rbGestionarPrecioLocal.Name = "rbGestionarPrecioLocal";
            this.rbGestionarPrecioLocal.Text = "Precio local";
            this.rbGestionarPrecioLocal.Click += new System.EventHandler(this.mnuiPrecioLocal_Click);
            // 
            // btnGestionarPrecioLocal
            // 
            this.btnGestionarPrecioLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarPrecioLocal.Image")));
            this.btnGestionarPrecioLocal.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarPrecioLocal.LargeImage")));
            this.btnGestionarPrecioLocal.Name = "btnGestionarPrecioLocal";
            this.btnGestionarPrecioLocal.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarPrecioLocal.SmallImage")));
            this.btnGestionarPrecioLocal.Text = "";
            this.btnGestionarPrecioLocal.Click += new System.EventHandler(this.mnuiPrecioLocal_Click);
            // 
            // rbGestionarCategoria
            // 
            this.rbGestionarCategoria.ButtonMoreVisible = false;
            this.rbGestionarCategoria.Items.Add(this.btnGestionarCategoria);
            this.rbGestionarCategoria.Name = "rbGestionarCategoria";
            this.rbGestionarCategoria.Text = "Categoría";
            this.rbGestionarCategoria.Click += new System.EventHandler(this.mnuiCategoria_Click);
            // 
            // btnGestionarCategoria
            // 
            this.btnGestionarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarCategoria.Image")));
            this.btnGestionarCategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarCategoria.LargeImage")));
            this.btnGestionarCategoria.Name = "btnGestionarCategoria";
            this.btnGestionarCategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarCategoria.SmallImage")));
            this.btnGestionarCategoria.Text = "";
            this.btnGestionarCategoria.Click += new System.EventHandler(this.mnuiCategoria_Click);
            // 
            // rbGestionarMarca
            // 
            this.rbGestionarMarca.ButtonMoreVisible = false;
            this.rbGestionarMarca.Items.Add(this.btnGestionarMarca);
            this.rbGestionarMarca.Name = "rbGestionarMarca";
            this.rbGestionarMarca.Text = "Marca";
            this.rbGestionarMarca.Click += new System.EventHandler(this.mnuiMarca_Click);
            // 
            // btnGestionarMarca
            // 
            this.btnGestionarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarMarca.Image")));
            this.btnGestionarMarca.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarMarca.LargeImage")));
            this.btnGestionarMarca.Name = "btnGestionarMarca";
            this.btnGestionarMarca.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarMarca.SmallImage")));
            this.btnGestionarMarca.Text = "";
            this.btnGestionarMarca.Click += new System.EventHandler(this.mnuiMarca_Click);
            // 
            // rbGestionarProducto
            // 
            this.rbGestionarProducto.ButtonMoreVisible = false;
            this.rbGestionarProducto.Items.Add(this.btnGestionarProducto);
            this.rbGestionarProducto.Name = "rbGestionarProducto";
            this.rbGestionarProducto.Text = "Producto";
            this.rbGestionarProducto.Click += new System.EventHandler(this.rbGestionarProducto_Click);
            // 
            // btnGestionarProducto
            // 
            this.btnGestionarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarProducto.Image")));
            this.btnGestionarProducto.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarProducto.LargeImage")));
            this.btnGestionarProducto.Name = "btnGestionarProducto";
            this.btnGestionarProducto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionarProducto.SmallImage")));
            this.btnGestionarProducto.Text = "";
            this.btnGestionarProducto.Click += new System.EventHandler(this.mnuiProducto_Click);
            // 
            // rtReportes
            // 
            this.rtReportes.Name = "rtReportes";
            this.rtReportes.Panels.Add(this.rpListadoProductos);
            this.rtReportes.Text = "Reportes";
            // 
            // rpListadoProductos
            // 
            this.rpListadoProductos.ButtonMoreVisible = false;
            this.rpListadoProductos.Items.Add(this.rbListadoProductos);
            this.rpListadoProductos.Name = "rpListadoProductos";
            this.rpListadoProductos.Text = "Listado de productos";
            this.rpListadoProductos.Click += new System.EventHandler(this.rbListadoProductos_Click);
            // 
            // rbListadoProductos
            // 
            this.rbListadoProductos.Image = ((System.Drawing.Image)(resources.GetObject("rbListadoProductos.Image")));
            this.rbListadoProductos.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbListadoProductos.LargeImage")));
            this.rbListadoProductos.Name = "rbListadoProductos";
            this.rbListadoProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbListadoProductos.SmallImage")));
            this.rbListadoProductos.Text = "";
            this.rbListadoProductos.Click += new System.EventHandler(this.rbListadoProductos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(915, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 592);
            this.Controls.Add(this.cintaOpciones);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon cintaOpciones;
        private System.Windows.Forms.RibbonTab rtGestion;
        private System.Windows.Forms.RibbonPanel rpGestionarEmpresa;
        private System.Windows.Forms.RibbonPanel rbGestionarLocal;
        private System.Windows.Forms.RibbonPanel rbGestionarPrecioLocal;
        private System.Windows.Forms.RibbonPanel rbGestionarCategoria;
        private System.Windows.Forms.RibbonPanel rbGestionarMarca;
        private System.Windows.Forms.RibbonPanel rbGestionarProducto;
        private System.Windows.Forms.RibbonButton btnGestionarEmpresa;
        private System.Windows.Forms.RibbonButton btnGestionarLocal;
        private System.Windows.Forms.RibbonButton btnGestionarPrecioLocal;
        private System.Windows.Forms.RibbonButton btnGestionarCategoria;
        private System.Windows.Forms.RibbonButton btnGestionarMarca;
        private System.Windows.Forms.RibbonButton btnGestionarProducto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RibbonTab rtDatos;
        private System.Windows.Forms.RibbonPanel rpPersonal;
        private System.Windows.Forms.RibbonPanel rpUsuario;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rbPersonal;
        private System.Windows.Forms.RibbonButton rbUsuario;
        private System.Windows.Forms.RibbonButton rbSalir;
        private System.Windows.Forms.RibbonTab rtReportes;
        private System.Windows.Forms.RibbonPanel rpListadoProductos;
        private System.Windows.Forms.RibbonButton rbListadoProductos;
    }
}