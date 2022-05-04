using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmGestionarProducto : Form
    {
        private Producto Actual;

        #region "Singleton"

        private static frmGestionarProducto frm;

        public frmGestionarProducto()
        {
          InitializeComponent();
        }

        public static frmGestionarProducto Crear(Form frmPadre)
        {
          if (frmGestionarProducto.frm == null)
          {
            frmGestionarProducto.frm = new frmGestionarProducto()
            {
              MdiParent = frmPadre,
              WindowState = FormWindowState.Maximized
            };
          }
          frmGestionarProducto.frm.BringToFront();

          return frmGestionarProducto.frm;
        }

        private void frmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
          frmGestionarProducto.frm = null;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(true);
            
            this.Actual = null;
        }

        private void LimpiarControles()
        {
            this.cboCategoria.SelectedIndex = -1;
            this.cboMarca.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.cboTipo.SelectedIndex = -1;
            this.cboTipoControl.SelectedIndex = -1;
            this.chkNegociable.Checked = false;
            this.chkNegociable.Enabled = true;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbEntidad.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtNombre.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            LimpiarControles();
            this.errError.Clear();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            this.CargarMarcas();
            this.CargarCategorias();
        }

        private void CargarMarcas()
        {
            RNMarca rn = new RNMarca();
            List<Marca> marcas;
            try
            {
                marcas = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboMarca, marcas,"Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            RNCategoria rn = new RNCategoria();
            List<Categoria> categorias;
            try
            {
                categorias = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboCategoria, categorias, "Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNProducto rn;
            Producto producto;

            if (this.ValidateChildren() == true)
            {
                producto = this.CrearEntidad();
                rn = new RNProducto();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(producto);
                    }
                    else
                    {
                        rn.Actualizar(producto);
                    }
                    this.LimpiarControles();
                    this.ActivarControles(false);
                    this.btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SonidoError();

                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private Producto CrearEntidad()
        {
            Producto pro = new Producto
            {
                Categoria = (Categoria)this.cboCategoria.SelectedItem,
                Marca = (Marca)this.cboMarca.SelectedItem,
                Nombre = this.txtNombre.Text,
                Tipo = this.cboTipo.Text.Substring(0,1),
                TipoControl = this.cboTipoControl.Text.Substring(0, 1),
                Negociable = this.chkNegociable.Checked, 
                Vigencia = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                pro.Codigo = this.Actual.Codigo;
            }
            return pro;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNProducto rn = new RNProducto();
            List<Producto> productos;

            try
            {
                productos = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, productos, "No se encontraron productos", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Producto)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNProducto rn = new RNProducto();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.cboCategoria.Text = this.Actual.Categoria.Nombre;
                    this.cboMarca.Text = this.Actual.Marca.Nombre;
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.cboTipo.Text = this.Actual.Tipo;
                    this.cboTipoControl.Text = this.Actual.TipoControl;
                    this.chkNegociable.Checked = this.Actual.Negociable;
                    this.chkNegociable.Enabled = true;
                    this.chkVigente.Checked = this.Actual.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SonidoError()
        {
            SystemSounds.Beep.Play();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) == false)
            {
                this.errError.SetError(this.txtNombre, "");
            }
            else
            {
                this.errError.SetError(this.txtNombre, "Debe ingresar un nombre");
                e.Cancel = true;
            }
        }

        private void cboMarca_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboMarca.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboMarca, "");
            }
            else
            {
                this.errError.SetError(this.cboMarca, "Debe seleccionar una marca");
                e.Cancel = true;
            }
        }

        private void cboTipo_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboTipo.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboTipo, "");
            }
            else
            {
                this.errError.SetError(this.cboTipo, "Debe seleccionar un tipo");
                e.Cancel = true;
            }
        }

        private void cboTipoControl_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboTipoControl.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboTipoControl, "");
            }
            else
            {
                this.errError.SetError(this.cboTipoControl, "Debe seleccionar un tipo de control");
                e.Cancel = true;
            }
        }

        private void cboCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboCategoria.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboCategoria, "");
            }
            else
            {
                this.errError.SetError(this.cboCategoria, "Debe seleccionar una categoria");
                e.Cancel = true;
            }
        }
    }
}
