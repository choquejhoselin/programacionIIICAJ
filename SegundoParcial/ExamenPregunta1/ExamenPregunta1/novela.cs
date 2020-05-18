using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    class novela
    {
        public novela(string titulo, string autor, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;

        }
        protected string Titulo;
        protected string Autor;
        protected string Genero;

        public override string ToString()
        {
            return Titulo + " " + Autor + " " + Genero + " ";
        }

        public string getTitulo()
        {
            return Titulo;
        }
        public void setTitulo(string titulo)
        {
            this.Titulo = titulo;

        }
        public string getAutor()
        {
            return Autor;
        }
        public void setAutor(string autor)
        {
            this.Autor = autor;
        }
        public string getGenero()
        {
            return Genero;
        }
        public void setGenero(string genero)
        {
            this.Autor = genero;
        }
    }
    
    
   
}
