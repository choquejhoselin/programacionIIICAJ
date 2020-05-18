using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    class Enciclopedia : ClaseLibro
    {
        public Enciclopedia(string nombre, string editorial, string tema)
        {
            Nombre = Nombre;

            Editorial = editorial;
            Tema = tema;
        }

        public string Nombre { get; set; }

        public string Editorial { get; set; }
        public string Tema { get; set; }

        override public string ToString()
        {
            return Nombre + " " + Editorial + "  " + Tema + "  ";
        }
    }
}
