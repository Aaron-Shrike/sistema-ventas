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
    public partial class frmReporteProductos : Form
    {
        #region "Singleton"

        private static frmReporteProductos frm;

        public static frmReporteProductos Crear(Form frmPadre)
        {
            if (frmReporteProductos.frm == null)
            {
                frmReporteProductos.frm = new frmReporteProductos()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmReporteProductos.frm.BringToFront();

            return frmReporteProductos.frm;
        }

        private void frmReporteProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReporteProductos.frm = null;
        }

        #endregion

        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            this.CargarEmpresas();
            this.CargarMarcas();
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

        private void CargarMarcas()
        {
            RNMarca rn = new RNMarca();
            List<Marca> marcas;
            try
            {
                marcas = rn.ListarVigentes();
                MisFunciones.EnlazarCombo(this.cboMarca, marcas, "Nombre", "Codigo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RNCategoria rn = new RNCategoria();
            List<Categoria> categorias;
            try
            {
                int codEmpresa = (int)this.cboEmpresa.SelectedValue;
                categorias = rn.ListarCategorias(codEmpresa);

                if (categorias != null && categorias.Count() > 0)
                {
                    MisFunciones.EnlazarCombo(this.cboCategoria, categorias, "Nombre", "Codigo");
                    this.gbListado.Enabled = true;
                    this.cboEmpresa.Enabled = false;
                    this.btnBuscar.Enabled = false;
                }
                else 
                {
                    MessageBox.Show("No se encontraron categorias", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.gbListado.Enabled = false;
            this.cboEmpresa.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.cboCategoria.SelectedIndex = -1;
            this.cboMarca.SelectedIndex = -1;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNProducto rn = new RNProducto();
            List<Producto> productos;

            try
            {
                int codCategoria = -1;
                int codMarca = -1;

                if (this.cboCategoria.SelectedIndex != -1) {
                    codCategoria = (int)this.cboCategoria.SelectedValue;
                }
                if (this.cboMarca.SelectedIndex != -1)
                {
                    codMarca = (int)this.cboMarca.SelectedValue;
                }

                productos = rn.Listar(codCategoria,codMarca);
                MisFunciones.EnlazarDataGrid(this.dgvListado, productos, "No se encontraron productos", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
