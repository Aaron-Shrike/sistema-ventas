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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogo frm = frmLogo.Crear(this);

            frm.Show();
            frm.BringToFront();
        }

        private void rbPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal frm = frmPersonal.Crear(this);

            frm.Show();
        }

        private void rbUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario frm = frmUsuario.Crear(this);

            frm.Show();
        }

        private void rbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuiEmpresa_Click(object sender, EventArgs e)
        {
            frmGestionarEmpresa frm = frmGestionarEmpresa.Crear(this);

            frm.Show();
        }

        private void mnuiLocal_Click(object sender, EventArgs e)
        {
            frmLocal frm = frmLocal.Crear(this);

            frm.Show();
        }

        private void mnuiPrecioLocal_Click(object sender, EventArgs e)
        {
            frmGestionarPrecioLocal frm = frmGestionarPrecioLocal.Crear(this);

            frm.Show();
        }

        private void mnuiCategoria_Click(object sender, EventArgs e)
        {
            frmGestionarCategoria frm = frmGestionarCategoria.Crear(this);

            frm.Show();
        }

        private void mnuiProducto_Click(object sender, EventArgs e)
        {
            frmGestionarProducto frm = frmGestionarProducto.Crear(this);

            frm.Show();
        }

        private void mnuiMarca_Click(object sender, EventArgs e)
        {
            frmGestionarMarca frm = frmGestionarMarca.Crear(this);

            frm.Show();
        }

        private void rbGestionarProducto_Click(object sender, EventArgs e)
        {
            frmGestionarProducto frm = frmGestionarProducto.Crear(this);

            frm.Show();
        }

        private void rbListadoProductos_Click(object sender, EventArgs e)
        {
            frmReporteProductos frm = frmReporteProductos.Crear(this);

            frm.Show();
        }

    }
}
