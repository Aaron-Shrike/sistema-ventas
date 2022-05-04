namespace Ventas
{
  partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEntidad = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblRepetir = new MetroFramework.Controls.MetroLabel();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.lblPersonal = new MetroFramework.Controls.MetroLabel();
            this.lblClave = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.txtRepetir = new MetroFramework.Controls.MetroTextBox();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.cboPersonal = new MetroFramework.Controls.MetroComboBox();
            this.btnAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkVigente = new MetroFramework.Controls.MetroCheckBox();
            this.gbListado = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvListado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cdPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbEntidad.Location = new System.Drawing.Point(16, 30);
            this.gbEntidad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbEntidad.Name = "gbEntidad";
            // 
            // gbEntidad.Panel
            // 
            this.gbEntidad.Panel.Controls.Add(this.lblRepetir);
            this.gbEntidad.Panel.Controls.Add(this.lblTipo);
            this.gbEntidad.Panel.Controls.Add(this.lblPersonal);
            this.gbEntidad.Panel.Controls.Add(this.lblClave);
            this.gbEntidad.Panel.Controls.Add(this.txtNombre);
            this.gbEntidad.Panel.Controls.Add(this.lblNombre);
            this.gbEntidad.Panel.Controls.Add(this.txtRepetir);
            this.gbEntidad.Panel.Controls.Add(this.txtClave);
            this.gbEntidad.Panel.Controls.Add(this.btnCancelar);
            this.gbEntidad.Panel.Controls.Add(this.cboTipo);
            this.gbEntidad.Panel.Controls.Add(this.cboPersonal);
            this.gbEntidad.Panel.Controls.Add(this.btnAceptar);
            this.gbEntidad.Panel.Controls.Add(this.chkVigente);
            this.gbEntidad.Size = new System.Drawing.Size(435, 306);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.Values.Heading = "Usuario";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.CustomBackground = true;
            this.lblRepetir.Location = new System.Drawing.Point(33, 131);
            this.lblRepetir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(51, 19);
            this.lblRepetir.TabIndex = 6;
            this.lblRepetir.Text = "&Repetir";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.CustomBackground = true;
            this.lblTipo.Location = new System.Drawing.Point(33, 164);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "&Tipo";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.CustomBackground = true;
            this.lblPersonal.Location = new System.Drawing.Point(33, 23);
            this.lblPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(59, 19);
            this.lblPersonal.TabIndex = 0;
            this.lblPersonal.Text = "&Personal";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.CustomBackground = true;
            this.lblClave.Location = new System.Drawing.Point(33, 95);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(41, 19);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Cla&ve";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.CustomBackground = true;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Location = new System.Drawing.Point(100, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 28);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CustomBackground = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 59);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "&Nombre";
            // 
            // txtRepetir
            // 
            this.txtRepetir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRepetir.CustomBackground = true;
            this.txtRepetir.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRepetir.Location = new System.Drawing.Point(100, 124);
            this.txtRepetir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRepetir.MaxLength = 100;
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(289, 28);
            this.txtRepetir.TabIndex = 7;
            this.txtRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepetir_Validating);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtClave.CustomBackground = true;
            this.txtClave.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClave.Location = new System.Drawing.Point(100, 88);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtClave.MaxLength = 100;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(289, 28);
            this.txtClave.TabIndex = 5;
            this.txtClave.Validating += new System.ComponentModel.CancelEventHandler(this.txtClave_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 240);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(99, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Values.Image")));
            this.btnCancelar.Values.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 19;
            this.cboTipo.Items.AddRange(new object[] {
            "Administrador",
            "Limitado"});
            this.cboTipo.Location = new System.Drawing.Point(100, 160);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(288, 25);
            this.cboTipo.TabIndex = 9;
            this.cboTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipo_Validating);
            // 
            // cboPersonal
            // 
            this.cboPersonal.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cboPersonal.FormattingEnabled = true;
            this.cboPersonal.ItemHeight = 19;
            this.cboPersonal.Location = new System.Drawing.Point(100, 19);
            this.cboPersonal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboPersonal.Name = "cboPersonal";
            this.cboPersonal.Size = new System.Drawing.Size(289, 25);
            this.cboPersonal.TabIndex = 1;
            this.cboPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.cboPersonal_Validating);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(186, 240);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 30);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Values.Image")));
            this.btnAceptar.Values.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.CustomBackground = true;
            this.chkVigente.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkVigente.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.chkVigente.Location = new System.Drawing.Point(33, 201);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(69, 19);
            this.chkVigente.TabIndex = 10;
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
            this.gbListado.Location = new System.Drawing.Point(459, 30);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbListado.Name = "gbListado";
            // 
            // gbListado.Panel
            // 
            this.gbListado.Panel.Controls.Add(this.dgvListado);
            this.gbListado.Panel.Controls.Add(this.btnListar);
            this.gbListado.Panel.Controls.Add(this.btnModificar);
            this.gbListado.Panel.Controls.Add(this.btnNuevo);
            this.gbListado.Size = new System.Drawing.Size(459, 275);
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
            this.cdUsuario});
            this.dgvListado.Location = new System.Drawing.Point(17, 71);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(419, 114);
            this.dgvListado.TabIndex = 1;
            // 
            // cdPersonal
            // 
            this.cdPersonal.DataPropertyName = "NombrePersonal";
            this.cdPersonal.HeaderText = "Personal";
            this.cdPersonal.Name = "cdPersonal";
            this.cdPersonal.ReadOnly = true;
            this.cdPersonal.Width = 300;
            // 
            // cdUsuario
            // 
            this.cdUsuario.DataPropertyName = "Nombre";
            this.cdUsuario.HeaderText = "Usuario";
            this.cdUsuario.Name = "cdUsuario";
            this.cdUsuario.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(318, 23);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(118, 32);
            this.btnListar.TabIndex = 0;
            this.btnListar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Values.Image")));
            this.btnListar.Values.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(116, 204);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 31);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Values.Image")));
            this.btnModificar.Values.Text = "Modificar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(17, 204);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 31);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Values.Image")));
            this.btnNuevo.Values.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(807, 309);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(111, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Values.Image")));
            this.btnCerrar.Values.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(935, 351);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEntidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
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
    private MetroFramework.Controls.MetroLabel lblRepetir;
    private MetroFramework.Controls.MetroLabel lblTipo;
    private MetroFramework.Controls.MetroLabel lblPersonal;
    private MetroFramework.Controls.MetroLabel lblClave;
    private MetroFramework.Controls.MetroTextBox txtNombre;
    private MetroFramework.Controls.MetroLabel lblNombre;
    private MetroFramework.Controls.MetroTextBox txtRepetir;
    private MetroFramework.Controls.MetroTextBox txtClave;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
    private MetroFramework.Controls.MetroComboBox cboTipo;
    private MetroFramework.Controls.MetroComboBox cboPersonal;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptar;
    private MetroFramework.Controls.MetroCheckBox chkVigente;
    private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbListado;
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvListado;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnListar;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnModificar;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevo;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdPersonal;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdUsuario;
  }
}