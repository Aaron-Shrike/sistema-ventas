using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Usuario
  {

    public int Codigo{ get; set; }
    public string Nombre { get; set; }
    public string Clave { get; set; }
    public string Tipo { get; set; }
    public bool Vigente { get; set; }
    public Personal Personal { get; set; }

    public string NombrePersonal
    {
      get
      {
        return ( this.Personal != null ? this.Personal.NombreCompleto : "");
      }
    }

  }
}
