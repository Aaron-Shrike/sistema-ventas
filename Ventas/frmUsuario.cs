using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  public partial class frmUsuario : Form
  {

    private Usuario Actual;

    #region "Singleton"

    private static frmUsuario frm;

    private frmUsuario()
    {
      InitializeComponent();
    }

    public static frmUsuario Crear(Form frmPadre)
    {
      if (frmUsuario.frm == null)
      {
        frmUsuario.frm = new frmUsuario()
        {
          MdiParent = frmPadre,
          WindowState = FormWindowState.Maximized
        };
      }
      frmUsuario.frm.BringToFront();

      return frmUsuario.frm;
    }

    private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
    {
      frmUsuario.frm = null;
    }


    #endregion

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        if (this.gbEntidad.Enabled && this.Actual == null)
        {
            MessageBox.Show("Hay un registro en curso, cancelelo para poder salir", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cboPersonal.Focus();
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
      this.cboPersonal.SelectedIndex = -1;
      this.txtNombre.Text = "";
      this.txtClave.Text = "";
      this.txtRepetir.Text = "";
      this.cboTipo.SelectedIndex = -1;
      this.chkVigente.Checked = true;
      this.chkVigente.Enabled = false;
      this.errError.Clear();
    }

    private void ActivarControles(bool estado)
    {
      this.gbEntidad.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if( estado == true)
      {
        this.cboPersonal.Focus();
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

    private void frmUsuario_Load(object sender, EventArgs e)
    {
      this.CargarDatos();
    }

    private void CargarDatos()
    {
      this.CargarPersonal();
    }

    private void CargarPersonal()
    {
      RNPersonal rn = new RNPersonal();
      List<Personal> trabajadores;
      try
      {
        trabajadores = rn.ListarVigentes();
        MisFunciones.EnlazarCombo(this.cboPersonal, trabajadores,
          "NombreCompleto", "Codigo");
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      RNUsuario rn;
      Usuario usuario;

      if (this.ValidateChildren() == true)
      {
          usuario = this.CrearEntidad();
          rn = new RNUsuario();
          try
          {
              if (this.Actual == null)
              {
                  rn.Registrar(usuario);
                  MessageBox.Show("Usuario registrado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                  rn.Actualizar(usuario);
                  MessageBox.Show("Usuario modificado exitosamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              this.ActivarControles(false);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
      else {
          this.AutoValidate = AutoValidate.EnableAllowFocusChange;
          Validaciones.SonidoError();
      }
    }

    private Usuario CrearEntidad()
    {
      return new Usuario
        {
          Personal = (Personal)this.cboPersonal.SelectedItem,
          Nombre = this.txtNombre.Text,
          Clave = this.txtClave.Text,
          Tipo = this.cboTipo.Text.Substring(0,1),
          Vigente = this.chkVigente.Checked 
        };
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
      RNUsuario rn = new RNUsuario();
      List<Usuario> usuarios;

      try
      {
        usuarios = rn.Listar();

        MisFunciones.EnlazarDataGrid(this.dgvListado, usuarios, "No se encontraron usuarios", this.Text);
      }catch(Exception ex) {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

    private void cboPersonal_Validating(object sender, CancelEventArgs e)
    {
        if (this.cboPersonal.SelectedIndex != -1)
        {
            this.errError.SetError(this.cboPersonal, "");
        }
        else
        {
            this.errError.SetError(this.cboPersonal, "Seleccione una miembro del Personal");
            e.Cancel = true;
        }
    }

    private void txtNombre_Validating(object sender, CancelEventArgs e)
    {
        string msgError;

        if (Validaciones.TextoValido(this.txtNombre, out msgError, "Nombre", 2, "Ingrese un Nombre valido de 2 dígitos como mínimo. Ejm: Sh"))
        {
            this.errError.SetError(this.txtNombre, "");
        }
        else
        {
            this.errError.SetError(this.txtNombre, msgError);
            e.Cancel = true;
        }
    }

    private void txtClave_Validating(object sender, CancelEventArgs e)
    {
        string msgError;

        if (Validaciones.TextoValido(this.txtClave, out msgError, "Clave", 8, "Ingrese una Clave valida de 8 dígitos como mínimo"))
        {
            this.errError.SetError(this.txtClave, "");
        }
        else
        {
            this.errError.SetError(this.txtClave, msgError);
            e.Cancel = true;
        }
    }

    private void txtRepetir_Validating(object sender, CancelEventArgs e)
    {
        string msgError;

        if (Validaciones.TextoRepetidoValido(this.txtClave, this.txtRepetir, out msgError, "Repetir Clave", "La Clave Repetida no coincide con la anterior ingresada"))
        {
            this.errError.SetError(this.txtRepetir, "");
        }
        else
        {
            this.errError.SetError(this.txtRepetir, msgError);
            e.Cancel = true;
        }
    }

    private void cboTipo_Validating(object sender, CancelEventArgs e)
    {
        if (this.cboTipo.SelectedIndex != -1)
        {
            this.errError.SetError(this.cboTipo, "");
        }
        else
        {
            this.errError.SetError(this.cboTipo, "Seleccione un Tipo");
            e.Cancel = true;
        }
    }
  }
}
