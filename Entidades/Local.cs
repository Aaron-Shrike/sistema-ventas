using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local
    {
        public int Codigo { get; set; }
        public Empresa Empresa { get; set; }
        public string Nombre {get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Vigente { get; set; }

        public string NombreEmpresa { get { return Empresa.RazonSocial; } }
    }
}
