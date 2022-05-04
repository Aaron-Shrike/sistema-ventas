using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  public class MisFunciones
  {

    public static void EnlazarDataGrid<T>(DataGridView dataGrid, 
      IEnumerable<T> datos,
      string msje = "", string titulo = "")
    {

      dataGrid.DataSource = null;
      if (datos != null && datos.Count() > 0)
      {
        dataGrid.AutoGenerateColumns = false;
        dataGrid.DataSource = datos;
      }
      else
      {
        if (string.IsNullOrEmpty(msje) == false)
        {
          MessageBox.Show(msje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    public static void EnlazarCombo<T>(ComboBox combo, IEnumerable<T> datos,
  string campoMostrar, string campoVinculado, string msje = "", string titulo = "")
    {

      combo.DataSource = null;
      if (datos != null && datos.Count() > 0)
      {
        combo.DisplayMember = campoMostrar;
        combo.ValueMember = campoVinculado;
        combo.DataSource = datos;
        combo.SelectedIndex = -1;
      }
      else
      {
        if (string.IsNullOrEmpty(msje) == false)
        {
          MessageBox.Show(msje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

  }

}
