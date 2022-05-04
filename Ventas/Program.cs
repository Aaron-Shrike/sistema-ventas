using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  static class Program
  {

    public static Usuario Usuario;

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      frmIdentificar frm;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

        frm = new frmIdentificar();
        Program.Usuario = frm.Identificar();

        if (Program.Usuario != null)
        {
            Application.Run(new frmPrincipal());
        }
    }
  }
}
