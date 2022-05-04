using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrecioLocal
    {
        public int Codigo { get; set; }
        public Local CodigoLocal { get; set; }
        public Producto CodigoProducto { get; set; }
        public double Precio { get; set; }
        public double PrecioMinimo { get; set; }
        public string TipoISC { get; set; }
        public double ISC { get; set; }
        public double IGV { get; set; }
        public double Exonerado { get; set; }
        public int Stock { get; set; }
        public bool Vigencia { get; set; }

        public string NombreLocal
        {
            get
            {
                return (this.CodigoLocal != null ? this.CodigoLocal.Nombre : "");
            }
        }
        public string NombreProducto
        {
            get
            {
                return (this.CodigoProducto != null ? this.CodigoProducto.Nombre : "");
            }
        }

    }
}
