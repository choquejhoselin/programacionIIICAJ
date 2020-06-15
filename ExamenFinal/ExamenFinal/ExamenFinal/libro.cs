using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class libro

    {
        string titulo;
        string autor;
        string editorial;
        Estadolibro estadolibro;
        private string estadolibro1;

        public libro(string titulo, string autor, string editorial, Estadolibro estadolibro)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.estadolibro = estadolibro;
        }

        public libro(string titulo, string autor, string editorial, string estadolibro1)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.estadolibro1 = estadolibro1;
        }

        public string GetTitulo()
        {
            return titulo;
        }
        public void setitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetAutor()
        {
            return autor;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetEditorial()
        {
            return editorial;
        }
        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public override string ToString()
        {
            return "titulo" + titulo + "autor" + autor + "Editorial" + editorial + "Estado" + estadolibro;
        }

        internal void imprimir()
        {
            throw new NotImplementedException();
        }
    }

    enum Estadolibro
    {
        Nuevo,seminuevo,Viejo
    }
}
