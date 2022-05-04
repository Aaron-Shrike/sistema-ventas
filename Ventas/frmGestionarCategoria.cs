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
using Entidades;
using ReglasNegocio;

namespace Ventas
{
    public partial class frmGestionarCategoria : Form
    {
        #region "Singleton"

        private static frmGestionarCategoria frm;

        public static frmGestionarCategoria Crear(Form frmPadre)
        {
            if (frmGestionarCategoria.frm == null)
            {
                frmGestionarCategoria.frm = new frmGestionarCategoria()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmGestionarCategoria.frm.BringToFront();

            return frmGestionarCategoria.frm;
        }

        private void frmGestionarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGestionarCategoria.frm = null;
        }

        #endregion

        public frmGestionarCategoria()
        {
            InitializeComponent();
        }

        private Categoria Actual;

        private void frmGestionarCategoria_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            this.CargarEmpresas();
        }

        private void CargarEmpresas()
        {
            RNEmpresa rn = new RNEmpresa();
            List<Empresa> empresas;
            try
            {
                empresas = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboEmpresa, empresas,
                  "RazonSocial", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNCategoria rn;
            Categoria categoria;

            if (this.ValidateChildren() == true)
            {
                categoria = this.CrearEntidad();
                rn = new RNCategoria();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(categoria);
                    }
                    else
                    {
                        rn.Actualizar(categoria);
                    }
                    this.LimpiarControles();
                    this.ActivarControles(false);
                    this.btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                   categoria = null;
                    rn = null;
                }
            }
            else
            {
                SonidoError();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private Categoria CrearEntidad()
        {
            Categoria cat = new Categoria
            {
                Empresa = (Empresa)this.cboEmpresa.SelectedItem,
                Nombre = this.txtNombre.Text,
                Descripcion = this.txtDescripcion.Text,
                Vigente = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                cat.Codigo = this.Actual.Codigo;
            }

            return cat;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivarControles(false);
            this.errErrorProvider.Clear();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Actual = null;
        }

        private void LimpiarControles()
        {
            this.cboEmpresa.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
            this.errErrorProvider.Clear();
        }

        private void SonidoError()
        {
            SystemSounds.Beep.Play();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Categoria)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Categoria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNCategoria rn = new RNCategoria();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.cboEmpresa.SelectedValue = this.Actual.Empresa.Codigo;
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.txtDescripcion.Text = this.Actual.Descripcion;
                    this.chkVigente.Checked = this.Actual.Vigente;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró la categoria indicada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNCategoria rn = new RNCategoria();
            List<Categoria> trabajadores;

            try
            {
                trabajadores = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, trabajadores, "No se encontraron Categorias", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) == false)
            {
                this.errErrorProvider.SetError(this.txtNombre, "");
            }
            else
            {
                this.errErrorProvider.SetError(this.txtNombre, "Indique el nombre");
                e.Cancel = true;
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDescripcion.Text) == false)
            {
                this.errErrorProvider.SetError(this.txtDescripcion, "");
            }
            else
            {
                this.errErrorProvider.SetError(this.txtDescripcion, "Indique la descripcion");
                e.Cancel = true;
            }
        }

        private void cboEmpresa_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboEmpresa.SelectedIndex > -1)
            {
                this.errErrorProvider.SetError(this.cboEmpresa, "");
            }
            else
            {
                this.errErrorProvider.SetError(this.cboEmpresa, "Indique la empresa");
                e.Cancel = true;
            }
        }


    }
}
