using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ReglasNegocio;

namespace Ventas
{
    public partial class frmGestionarEmpresa : Form
    {
        #region "Singleton"

        private static frmGestionarEmpresa frm;

        public static frmGestionarEmpresa Crear(Form frmPadre)
        {
            if (frmGestionarEmpresa.frm == null)
            {
                frmGestionarEmpresa.frm = new frmGestionarEmpresa()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmGestionarEmpresa.frm.BringToFront();

            return frmGestionarEmpresa.frm;
        }

        private void frmGestionarEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGestionarEmpresa.frm = null;
        }

        #endregion

        public frmGestionarEmpresa()
        {
            InitializeComponent();
        }

        private Empresa Actual;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNEmpresa rn;
            Empresa empresa;

            if (this.ValidateChildren() == true)
            {
                empresa = this.CrearEntidad();
                rn = new RNEmpresa();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(empresa);
                    }
                    else
                    {
                        rn.Actualizar(empresa);
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
                    empresa = null;
                    rn = null;
                }
            }
            else
            {
                SonidoError();
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private Empresa CrearEntidad()
        {
            Empresa emp = new Empresa
            {
                RazonSocial = this.txtRazonSocial.Text,
                Ruc = this.txtRUC.Text ,
                Facebook = this.txtFacebook.Text,
                Instagram = this.txtInstagram.Text,
                Youtube = this.txtYoutube.Text,
                Whatsapp = this.txtWhastapp.Text,
                Correo = this.txtCorreo.Text,
                Logo = this.txtLogo.Text,
                Vigente = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                emp.Codigo = this.Actual.Codigo;
            }
            return emp;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void LimpiarControles()
        {
            this.txtRazonSocial.Text = "";
            this.txtRUC.Text = "";
            this.txtFacebook.Text = "";
            this.txtInstagram.Text = "";
            this.txtYoutube.Text = "";
            this.txtWhastapp.Text = "";
            this.txtCorreo.Text = "";
            this.txtLogo.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
            this.errError.Clear();
        }

        private void ActivarControles(bool estado)
        {
            this.gbEmpresa.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtRazonSocial.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNEmpresa rn = new RNEmpresa();
            List<Empresa> trabajadores;

            try
            {
                trabajadores = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, trabajadores, "No se encontraron empresas", this.Text);
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
                this.Actual = (Empresa)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una empresa", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNEmpresa rn = new RNEmpresa();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.txtRazonSocial.Text = this.Actual.RazonSocial;
                    this.txtRUC.Text = this.Actual.Ruc;
                    this.txtFacebook.Text = this.Actual.Facebook;
                    this.txtInstagram.Text = this.Actual.Instagram;
                    this.txtYoutube.Text = this.Actual.Youtube;
                    this.txtWhastapp.Text = this.Actual.Whatsapp;
                    this.txtCorreo.Text = this.Actual.Correo;
                    this.txtLogo.Text = this.Actual.Logo;
                    this.chkVigente.Checked = this.Actual.Vigente;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró la empresa indicada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRazonSocial.Text) == false)
            {
                this.errError.SetError(this.txtRazonSocial, "");
            }
            else
            {
                this.errError.SetError(this.txtRazonSocial, "Debe indicar la Razón Social");
                e.Cancel = true;
            }
        }


        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRUC.Text) == false)
            {
                this.errError.SetError(this.txtRUC, "");
                if (txtRUC.Text.Count() == 11)
                {
                    this.errError.SetError(this.txtRUC, "");
                }
                else
                {
                    this.errError.SetError(this.txtRUC, "Número de RUC debe de tener 11 dígitos");
                    //this.txtRUC.Focus();
                    e.Cancel = true;
                }
            }
            else
            {
                this.errError.SetError(this.txtRUC, "Debe indicar el RUC");
                e.Cancel = true;
            }
        }

        private void txtFacebook_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFacebook.Text) == false)
            {
                this.errError.SetError(this.txtFacebook, "");
            }
            else
            {
                this.errError.SetError(this.txtFacebook, "Debe indicar el Facebook");
                e.Cancel = true;
            }
        }

        private void txtInstagram_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInstagram.Text) == false)
            {
                this.errError.SetError(this.txtInstagram, "");
            }
            else
            {
                this.errError.SetError(this.txtInstagram, "Debe indicar el Instagram");
                e.Cancel = true;
            }
        }

        private void txtYoutube_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtYoutube.Text) == false)
            {
                this.errError.SetError(this.txtYoutube, "");
            }
            else
            {
                this.errError.SetError(this.txtYoutube, "Debe indicar el Youtube");
                e.Cancel = true;
            }
        }

        private void txtWhastapp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtWhastapp.Text) == false)
            {
                this.errError.SetError(this.txtWhastapp, "");

                if (txtWhastapp.Text.Count() == 9)
                {
                    this.errError.SetError(this.txtWhastapp, "");
                }
                else
                {
                    this.errError.SetError(this.txtWhastapp, "Whatsapp debe de tener 9 dígitos");
                    e.Cancel = true;
                }
            }
            else
            {
                this.errError.SetError(this.txtWhastapp, "Debe indicar el Whastapp");
                e.Cancel = true;
            }
        }

        public static bool Email_Valido(String email)
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCorreo.Text) == false)
            {
                this.errError.SetError(this.txtCorreo, "");

                if (Email_Valido(txtCorreo.Text) == false)
                {
                    errError.SetError(txtCorreo, " Ingrese un Email Válido");
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                this.errError.SetError(this.txtCorreo, "Debe indicar el Correo");
                e.Cancel = true;
            }
        }

        private void txtLogo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLogo.Text) == false)
            {
                this.errError.SetError(this.txtLogo, "");
            }
            else
            {
                this.errError.SetError(this.txtLogo, "Debe indicar el Logo");
                e.Cancel = true;
            }
        }

        private void txtWhastapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
