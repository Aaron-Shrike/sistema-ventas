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
  public partial class frmPrincipal2 : Form
  {
    public frmPrincipal2()
    {
      InitializeComponent();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void mnuPersonal_Click(object sender, EventArgs e)
    {
      frmPersonal frm = frmPersonal.Crear(this);

      frm.Show();
    }

    private void mnuUsuario_Click(object sender, EventArgs e)
    {
      frmUsuario  frm = frmUsuario.Crear(this);

      frm.Show();
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
  }
}
