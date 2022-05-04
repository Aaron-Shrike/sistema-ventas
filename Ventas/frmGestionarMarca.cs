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
    public partial class frmGestionarMarca : Form
    {
        #region "Singleton"

        private static frmGestionarMarca frm;

        public static frmGestionarMarca Crear(Form frmPadre)
        {
            if (frmGestionarMarca.frm == null)
            {
                frmGestionarMarca.frm = new frmGestionarMarca()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmGestionarMarca.frm.BringToFront();

            return frmGestionarMarca.frm;
        }

        private void frmGestionarMarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGestionarMarca.frm = null;
        }

        #endregion
        
        public frmGestionarMarca()
        {
            InitializeComponent();
        }

        private Marca Actual;

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
                    marca = null;
                    rn = null;
                }
            }
            else
            {
                SonidoError();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private Marca CrearEntidad()
        {
            Marca marc = new Marca
            {
                Nombre = this.txtNombre.Text,
                Vigente = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                marc.Codigo = this.Actual.Codigo;
            }

            return marc;
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
            this.txtNombre.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
            //this.errError.Clear();
        }

        private void SonidoError()
        {
            SystemSounds.Beep.Play();
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNMarca rn = new RNMarca();
            List<Marca> marcas;

            try 
            {
                marcas = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, marcas, "No se encontraron Marcas", this.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    this.chkVigente.Enabled = true;
                    this.chkVigente.Checked = this.Actual.Vigente;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró la Marca indicada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNombre_Validating_1(object sender, CancelEventArgs e)
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
    }
}
