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
    public partial class frmGestionarPrecioLocal : Form
    {
        private PrecioLocal Actual;
        #region "Singleton"

        private static frmGestionarPrecioLocal frm;

        public static frmGestionarPrecioLocal Crear(Form frmPadre)
        {
            if (frmGestionarPrecioLocal.frm == null)
            {
                frmGestionarPrecioLocal.frm = new frmGestionarPrecioLocal()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmGestionarPrecioLocal.frm.BringToFront();

            return frmGestionarPrecioLocal.frm;
        }

        private void frmPrecioLocal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGestionarPrecioLocal.frm = null;
        }

        #endregion

        public frmGestionarPrecioLocal()
        {
            InitializeComponent();
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
            this.cboNombreLocal.SelectedIndex = -1;
            this.cboNombreProducto.SelectedIndex = -1;
            this.cboTipoISC.SelectedIndex = -1;
            this.nudPrecio.Value=nudPrecio.Minimum;
            this.nudPrecioMinimo.Value = nudPrecioMinimo.Minimum;
            this.nudIGV.Value=nudIGV.Minimum;
            this.nudISC.Value = nudISC.Minimum;
            this.nudStock.Value = nudStock.Minimum;
            this.nudExonerado.Value = nudExonerado.Minimum;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbEntidad.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.cboNombreLocal.Focus();
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

        private void frmGestionarPrecioLocal_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            this.CargarLocal();
            this.CargarProducto();
        }

        private void CargarLocal()
        {
            RNLocal rn = new RNLocal();
            List<Local> locales;
            try
            {
                locales = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboNombreLocal,locales, "Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProducto()
        {
            RNProducto rn = new RNProducto();
            List<Producto> productos;
            try
            {
                productos = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboNombreProducto, productos, "Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            RNPrecioLocal rn;
            PrecioLocal precioLocal;

            if (this.ValidateChildren() == true)
            {
                precioLocal = this.CrearEntidad();
                rn = new RNPrecioLocal();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(precioLocal);
                    }
                    else
                    {
                        rn.Actualizar(precioLocal);
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
            }
        }

        private PrecioLocal CrearEntidad()
        {
            PrecioLocal pre = new PrecioLocal
            {
               
                CodigoLocal = (Local)this.cboNombreLocal.SelectedItem,
                CodigoProducto = (Producto)this.cboNombreProducto.SelectedItem,
                Precio =(double)nudPrecio.Value,
                PrecioMinimo =(double)nudPrecioMinimo.Value,
                TipoISC=this.cboTipoISC.Text.Substring(0,1),
                ISC =(double)nudISC.Value,
                IGV =(double)nudIGV.Value,
                Exonerado =(double)nudExonerado.Value,
                Stock =(int)nudStock.Value,
                Vigencia = this.chkVigente.Checked
            };
            if (this.Actual != null)
            {
                pre.Codigo = this.Actual.Codigo;
            }
            return pre;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNPrecioLocal rn = new RNPrecioLocal();
            List<PrecioLocal> precioLocales;

            try
            {
                precioLocales = rn.Listar();
                MisFunciones.EnlazarDataGrid(this.dgvListado, precioLocales, "No se encontraron precios Locales", this.Text);
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
                this.Actual = (PrecioLocal)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un precio local", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PresentarDatos()
        {
            RNPrecioLocal rn = new RNPrecioLocal();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    
                    this.cboNombreLocal.Text = this.Actual.CodigoLocal.Nombre;
                    this.cboNombreProducto.Text = this.Actual.CodigoProducto.Nombre;
                    this.cboTipoISC.Text = this.Actual.TipoISC;
                    this.nudPrecio.Value = (decimal)this.Actual.Precio;
                    this.nudPrecioMinimo.Value = (decimal)this.Actual.PrecioMinimo;
                    this.nudISC.Value = (decimal)this.Actual.ISC;
                    this.nudIGV.Value = (decimal)this.Actual.IGV;
                    this.nudExonerado.Value = (decimal)this.Actual.Exonerado;
                    this.nudStock.Value = this.Actual.Stock;
                    this.chkVigente.Checked = this.Actual.Vigencia;
                    this.chkVigente.Enabled = true;
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontró el precio local indicado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboNombreLocal_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboNombreLocal.SelectedIndex>-1)
            {
                this.errError.SetError(this.cboNombreLocal, "");
            }
            else
            {
                this.errError.SetError(this.cboNombreLocal, "Debe seleccionar un nombre de local");
                e.Cancel = true;
            }
        }

        private void cboNombreProducto_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboNombreProducto.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboNombreProducto, "");
            }
            else
            {
                this.errError.SetError(this.cboNombreProducto, "Debe seleccionar un nombre de producto");
                e.Cancel = true;
            }
        }

        private void nudPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (this.nudPrecio.Value > 0)
            {
                this.errError.SetError(this.nudPrecio, "");
            }
            else
            {
                this.errError.SetError(this.nudPrecio, "Debe ingresar un monto al precio");
                e.Cancel = true;
            }

        }

        private void nudPrecioMinimo_Validating(object sender, CancelEventArgs e)
        {
            if (this.nudPrecioMinimo.Value > 0)
            {
                this.errError.SetError(this.nudPrecioMinimo, "");
            }
            else
            {
                this.errError.SetError(this.nudPrecioMinimo, "Debe ingresar un monto al precio minimo");
                e.Cancel = true;
            }
        }

        private void cboTipoISC_Validating(object sender, CancelEventArgs e)
        {

            if (this.cboTipoISC.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboTipoISC, "");
            }
            else
            {
                this.errError.SetError(this.cboTipoISC, "Debe seleccionar un tipo de ISG");
                e.Cancel = true;
            }
        }

        private void nudISC_Validating(object sender, CancelEventArgs e)
        {
            if (this.nudISC.Value > 0)
            {
                this.errError.SetError(this.nudISC, "");
            }
            else
            {
                this.errError.SetError(this.nudISC, "Debe ingresar un monto a ISC");
                e.Cancel = true;
            }
        }

        private void nudIGV_Validating(object sender, CancelEventArgs e)
        {
            if (this.nudIGV.Value > 0)
            {
                this.errError.SetError(this.nudIGV, "");
            }
            else
            {
                this.errError.SetError(this.nudIGV, "Debe ingresar un monto al IGV");
                e.Cancel = true;
            }
        }

        private void nudStock_Validating(object sender, CancelEventArgs e)
        {
            if (this.nudStock.Value > 0)
            {
                this.errError.SetError(this.nudStock, "");
            }
            else
            {
                this.errError.SetError(this.nudStock, "Debe ingresar una cantidad al stock");
                e.Cancel = true;
            }
        }

        

    }
}
