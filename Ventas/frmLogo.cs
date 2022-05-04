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
    public partial class frmLogo : Form
    {
        #region "Singleton"

        private static frmLogo frm;

        public static frmLogo Crear(Form frmPadre)
        {
            if (frmLogo.frm == null)
            {
                frmLogo.frm = new frmLogo()
                {
                    MdiParent = frmPadre,
                    WindowState = FormWindowState.Maximized
                };
            }
            frmLogo.frm.BringToFront();

            return frmLogo.frm;
        }

        private void frmLogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogo.frm = null;
        }

        #endregion

        public frmLogo()
        {
            InitializeComponent();
        }


    }
}
