using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen_final_prograBiblioteca
{
    class Biblioteca
    {
        string Nombre;
        string Direccion;
        int numTelefono;
        List<Libro> ListaLibros;
        private static Biblioteca instance;
        public static Biblioteca getInstance()
        {
            if (instance == null)
            {
                instance = new Biblioteca();
            }
            return instance;
        }
        private Biblioteca()
        {
            this.Nombre = "Biblioteca Univalle";
            this.Direccion = "Pasaje Guillermina";
            this.numTelefono = 64255233;
            ListaLibros = new List<Libro>();

        }
        public void InsertarLibro(Libro x)
        {
            ListaLibros.Add(x);
        }
        public void Removerlibro(Libro y)
        {
            ListaLibros.Remove(y);

        }

        public void MostrarLoslibros()
        {
            foreach (Libro o in ListaLibros) ;

            {
                Console.WriteLine("{0}", 0);
            }
        }
    }

}






