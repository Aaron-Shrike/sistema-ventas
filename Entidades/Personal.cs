using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Personal
    {

        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string DNI { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Vigente { get; set; }

        public string NombreCompleto
        {
            get
            {
                return this.ApellidoPaterno + " " + this.ApellidoMaterno
                    + " " + this.Nombres;
            }
        }

    }
}
