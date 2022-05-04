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
    public partial class frmLocal : Form
    {
        #region "Singleton"

        private static frmLocal frm;

        public static frmLocal Crear(Form frmPadre)
        {
            if (frmLocal.frm == null)
            {
                frmLocal.frm = new frmLocal()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmLocal.frm.BringToFront();

            return frmLocal.frm;
        }

        private void frmLocal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLocal.frm = null;
        }

        #endregion


        private Local Actual;

        public frmLocal()
        {
            InitializeComponent();
        }

        private void frmLocal_Load(object sender, EventArgs e)
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
                MisFunciones.EnlazarCombo(this.cboEmpresa, empresas, "RazonSocial", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNLocal rn = new RNLocal();
            List<Local> locales;

            try
            {
                locales = rn.Listar();

                MisFunciones.EnlazarDataGrid(this.dgvListado, locales, "No se encontraron locales", this.Text);
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
                this.cboEmpresa.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void LimpiarControles()
        {
            this.cboEmpresa.SelectedIndex = -1;
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
            this.errError.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Local)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un local", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNLocal rn = new RNLocal();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.cboEmpresa.SelectedValue = this.Actual.Empresa.Codigo;
                    this.txtNombre.Text = this.Actual.Nombre;
                    this.txtDireccion.Text = this.Actual.Direccion;
                    this.txtTelefono.Text = this.Actual.Telefono;
                    this.chkVigente.Checked = this.Actual.Vigente;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el local indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNLocal rn;
            Local local;

            if (this.ValidateChildren() == true)
            {
                local = this.CrearEntidad();
                rn = new RNLocal();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(local);
                        MessageBox.Show("Local registrado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rn.Actualizar(local);
                        MessageBox.Show("Local modificado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    local = null;
                    rn = null;
                }
            }
            else
            {
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
                Validaciones.SonidoError();
            }
        }

        private Local CrearEntidad()
        {
            Local loc = new Local
            {
                Empresa = (Empresa)this.cboEmpresa.SelectedItem,
                Nombre = this.txtNombre.Text,
                Direccion = this.txtDireccion.Text,
                Telefono = this.txtTelefono.Text,
                Vigente = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                loc.Codigo = this.Actual.Codigo;
            }

            return loc;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.Actual == null)
            {
                DialogResult respuesta = MessageBox.Show("Perderá los datos ingresados, ¿Desea salir?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    this.ActivarControles(false);
                }
            }
            else
            {
                this.ActivarControles(false);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.gbEntidad.Enabled && this.Actual == null)
            {
                MessageBox.Show("Hay un registro en curso, cancelelo para poder salir", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboEmpresa.Focus();
            }
            else if (this.gbEntidad.Enabled && this.Actual != null)
            {
                DialogResult respuesta = MessageBox.Show("Hay una modificación en curso, ¿Desea salir?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        //VALIDACIONES

        private void cboEmpresa_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboEmpresa.SelectedIndex != -1)
            {
                this.errError.SetError(this.cboEmpresa, "");
            }
            else
            {
                this.errError.SetError(this.cboEmpresa, "Seleccione una Empresa");
                e.Cancel = true;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.TextoValido(this.txtNombre, out msgError, "Nombre", 3, "Ingrese un Nombre válido de 3 dígitos como mínimo. Ejm: G&P"))
            {
                this.errError.SetError(this.txtNombre, "");
            }
            else
            {
                this.errError.SetError(this.txtNombre, msgError);
                e.Cancel = true;
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.TextoValido(this.txtDireccion, out msgError, "Direccion", 5, "Ingrese una Dirección válida de 5 dígitos como mínimo. Ejm: Asent"))
            {
                this.errError.SetError(this.txtDireccion, "");
            }
            else
            {
                this.errError.SetError(this.txtDireccion, msgError);
                e.Cancel = true;
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.NumeroDigitosValido(this.txtTelefono, out msgError, "Teléfono", 9, "Ingrese un Teléfono válido de 9 dígitos en caso sea un Teléfono fijo anteponer el código de  provincia"))
            {
                this.errError.SetError(this.txtTelefono, "");
            }
            else
            {
                this.errError.SetError(this.txtTelefono, msgError);
                e.Cancel = true;
            }
        }

    }
}
