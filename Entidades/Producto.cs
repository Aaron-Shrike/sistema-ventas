using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string Tipo { get; set; }
        public bool Negociable { get; set; }
        public string Nombre { get; set; }
        public string TipoControl { get; set; }
        public bool Vigencia { get; set; }

        public string NombreCategoria
        {
            get
            {
                return (this.Categoria != null ? this.Categoria.Nombre : "");
            }
        }

        public string NombreMarca
        {
            get
            {
                return (this.Marca != null ? this.Marca.Nombre : "");
            }
        }


    }
}
