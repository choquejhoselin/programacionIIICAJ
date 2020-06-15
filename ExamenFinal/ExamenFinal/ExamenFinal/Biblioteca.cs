using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Biblioteca
    {
      
        String nombre;
        String direccion;
        int nrotelefeno;
        List<libro> ListaLibros;

        private static Biblioteca instance;
        
        public static Biblioteca getInstance()
        {
            if (instance==null)
            {
                instance = new Biblioteca();
            }
            return instance;
        }
        private Biblioteca()
        {
            this.nombre = "Biblioteca Univalle";
            this.direccion = "Pasaje Guillermina";
            this.nrotelefeno = 64255233;
            ListaLibros = new List<libro>();
        }
        public void InsertarLibro(libro x)
        {
            ListaLibros.Add(x);
        }
        public void RemoverLibro(libro P)
        {
            ListaLibros.Remove(P);
        }
       
    }
}
