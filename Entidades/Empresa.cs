using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string Whatsapp { get; set; }
        public string Correo { get; set; }
        public string Logo { get; set; }
        public bool Vigente { get; set; }
    }
}
