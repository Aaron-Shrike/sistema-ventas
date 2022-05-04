using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ReglasNegocio;

namespace Ventas
{
    public partial class frmMarca : Form
    {
        #region "Singleton"

        private static frmMarca frm;

        public static frmMarca Crear(Form frmPadre)
        {
            if (frmMarca.frm == null)
            {
                frmMarca.frm = new frmMarca()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmMarca.frm.BringToFront();

            return frmMarca.frm;
        }

        private void frmMarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMarca.frm = null;
        }

        #endregion
        
        private Marca Actual;

        public frmMarca()
        {
            InitializeComponent();
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            RNMarca rn = new RNMarca();
            List<Marca> marcas;

            try
            {
                marcas = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, marcas, "No se encontraron marcas", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Actual = null;
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

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Marca)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNMarca rn = new RNMarca();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.chkVigente.Checked = this.Actual.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró la marca indicada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNMarca rn;
            Marca marca;

            if (this.ValidateChildren() == true)
            {
                marca = this.CrearEntidad();
                rn = new RNMarca();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(marca);
                    }
                    else
                    {
                        rn.Actualizar(marca);
                    }
                    this.ActivarControles(false);
                    this.btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    marca = null;
                    rn = null;
                }
            }
        }

        private Marca CrearEntidad()
        {
            Marca mar = new Marca
            {
                Nombre = this.txtNombre.Text,
                Vigencia = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                mar.Codigo = this.Actual.Codigo;
            }

            return mar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
