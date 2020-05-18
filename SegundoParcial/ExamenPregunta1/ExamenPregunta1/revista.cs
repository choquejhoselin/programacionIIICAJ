using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    class revista:Libros
    {
        public revista(string titulo, int nropagina)
        {
            Titulo = titulo;

            Nropagina = nropagina;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Nropagina { get; set; }

        override public string ToString()
        {
            return Titulo + " " + Nropagina + "  ";
        }

    }
}
