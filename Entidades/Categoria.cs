using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public Empresa Empresa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Vigente { get; set; }

        public string NombreEmpresa { get { return Empresa.RazonSocial; } }
    }
}
