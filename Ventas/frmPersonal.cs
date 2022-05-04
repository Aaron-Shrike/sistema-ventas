using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmPersonal : Form
    {

        #region "Singleton"

        private static frmPersonal frm;

        private frmPersonal()
        {
          InitializeComponent();
        }

        public static frmPersonal Crear(Form frmPadre )
        {
          if( frmPersonal.frm == null)
          {
            frmPersonal.frm = new frmPersonal()
            {
                MdiParent = frmPadre,
                WindowState = FormWindowState.Maximized
            };
          }
          frmPersonal.frm.BringToFront();

          return frmPersonal.frm;
        }

        private void frmPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
          frmPersonal.frm = null;
        }

        #endregion

        private Personal Actual;


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.gbEntidad.Enabled && this.Actual == null)
            {
                MessageBox.Show("Hay un registro en curso, cancelelo para poder salir", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDNI.Focus();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          this.ActivarControles(true);
          this.LimpiarControles();
          this.Actual = null;
        }

        private void LimpiarControles()
        {
          this.txtDNI.Text = "";
          this.txtNombres.Text = "";
          this.txtApellidoPaterno.Text = "";
          this.txtApellidoMaterno.Text = "";
          this.txtCelular.Text = "";
          this.txtCorreo.Text = "";
          this.chkVigente.Checked = true;
          this.chkVigente.Enabled = false;
          this.errError.Clear();
        }

        private void ActivarControles(bool estado)
        {
          this.gbEntidad.Enabled = estado;
          this.gbListado.Enabled = !estado;
          if (estado == true)
          {
            this.txtDNI.Focus();
          }
          else
          {
            this.btnListar.Focus();
          }
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

        private void btnListar_Click(object sender, EventArgs e)
        {
          RNPersonal rn = new RNPersonal();
          List<Personal> trabajadores;

          try
          {
            trabajadores = rn.Listar();
            MisFunciones.EnlazarDataGrid(this.dgvListado, trabajadores, "No se encontraron trabajadores", this.Text);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          RNPersonal rn;
          Personal trabajador;

          if (this.ValidateChildren() == true)
          {
              trabajador = this.CrearEntidad();
              rn = new RNPersonal();
              try
              {
                  if (this.Actual == null)
                  {
                      rn.Registrar(trabajador);
                      MessageBox.Show("Personal registrado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  else
                  {
                      //codigo se obtiene en la función crearEntidad
                      rn.Actualizar(trabajador);
                      MessageBox.Show("Personal modificado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                  trabajador = null;
                  rn = null;
              }
          }
          else 
          {
              this.AutoValidate = AutoValidate.EnableAllowFocusChange;
              Validaciones.SonidoError();
          }

        }

        private Personal CrearEntidad()
        {
          Personal per = new Personal
          {
            DNI = this.txtDNI.Text,
            Nombres = this.txtNombres.Text,
            ApellidoPaterno = this.txtApellidoPaterno.Text,
            ApellidoMaterno = this.txtApellidoMaterno.Text,
            Celular = this.txtCelular.Text,
            Correo = this.txtCorreo.Text,
            FechaNacimiento = this.dtpFechaNacimiento.Value,
            Vigente = this.chkVigente.Checked
          };
          if (this.Actual != null)
          {
            per.Codigo = this.Actual.Codigo;
          }

          return per;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          if (this.dgvListado.CurrentRow != null)
          {
            this.Actual = (Personal)this.dgvListado.CurrentRow.DataBoundItem;
            this.PresentarDatos();
          }
          else
          {
            MessageBox.Show("Debe seleccionar un trabajador", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }

        private void PresentarDatos()
        {
          RNPersonal rn = new RNPersonal();

          try
          {
            this.Actual = rn.Leer(this.Actual.Codigo);
            if (this.Actual != null)
            {
              this.txtDNI.Text = this.Actual.DNI;
              this.txtNombres.Text = this.Actual.Nombres;
              this.txtApellidoPaterno.Text = this.Actual.ApellidoPaterno;
              this.txtApellidoMaterno.Text = this.Actual.ApellidoMaterno;
              this.dtpFechaNacimiento.Value = this.Actual.FechaNacimiento;
              this.txtCelular.Text = this.Actual.Celular;
              this.txtCorreo.Text = this.Actual.Correo;
              this.chkVigente.Checked = this.Actual.Vigente;
              this.chkVigente.Enabled = true;
              this.ActivarControles(true);
            }
            else
            {
              MessageBox.Show("No se encontró el personal indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.NumeroDigitosValido(this.txtDNI, out msgError, "DNI", 8, "Ingrese un DNI valido de 8 digitos. Ejm: 73979767"))
            {
                this.errError.SetError(this.txtDNI, "");
            }
            else
            {
                this.errError.SetError(this.txtDNI, msgError);
                e.Cancel = true;
            }
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.TextoValido(this.txtNombres, out msgError, "Nombre", 3, "Ingrese un Nombre valido de 3 digitos como minimo. Ejm: Aarón"))
            {
                this.errError.SetError(this.txtNombres, "");
            }
            else
            {
                this.errError.SetError(this.txtNombres, msgError);
                e.Cancel = true;
            }
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.TextoValido(this.txtApellidoPaterno, out msgError, "Apellido Paterno", 3, "Ingrese un Apellido Paterno valido de 3 digitos como minimo. Ejm: Rojas"))
            {
                this.errError.SetError(this.txtApellidoPaterno, "");
            }
            else
            {
                this.errError.SetError(this.txtApellidoPaterno, msgError);
                e.Cancel = true;
            }
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.TextoValido(this.txtApellidoMaterno, out msgError, "Apellido Materno", 3, "Ingrese un Apellido Materno valido de 3 digitos como minimo. Ejm: Vera"))
            {
                this.errError.SetError(this.txtApellidoMaterno, "");
            }
            else
            {
                this.errError.SetError(this.txtApellidoMaterno, msgError);
                e.Cancel = true;
            }
        }

        private void txtCelular_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.NumeroDigitosValido(this.txtCelular, out msgError, "Celular", 9, "Ingrese un Celular valido de 9 digitos. Ejm: 978488925"))
            {
                this.errError.SetError(this.txtCelular, "");
            }
            else
            {
                this.errError.SetError(this.txtCelular, msgError);
                e.Cancel = true;
            }
        }

        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string msgError;

            if (Validaciones.CorreoValido(this.txtCorreo, out msgError, "Ingrese un Correo valido. Ejm: arojasv@unprg.edu.pe"))
            {
                this.errError.SetError(this.txtCorreo, "");
            }
            else
            {
                this.errError.SetError(this.txtCorreo, msgError);
                e.Cancel = true;
            }
        }

    }
}
