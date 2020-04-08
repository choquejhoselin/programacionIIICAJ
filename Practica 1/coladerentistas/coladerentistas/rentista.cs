using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladerentistas
{
    class rentista
    {
        public rentista(string nombre, string apellido, string sexo, int edad,string sector)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo= sexo;
            Edad = edad;
            Sector = sector;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Sector { get; set; }
        override public string ToString()
        {
            return Nombre + " " + Apellido + "  " + Sexo + "  " + Edad + "  " + Sector+" ";
        }

    }
}
