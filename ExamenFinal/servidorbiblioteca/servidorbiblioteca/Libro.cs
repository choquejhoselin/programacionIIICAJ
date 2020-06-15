using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_final_prograBiblioteca
{
    class Libro
    {
        string titulolibro;
        string autor;
        string editorial;
        Estado estado;

        public Libro(string titulolibro, string autor, string editorial, Estado estado)
        {
            this.titulolibro = titulolibro;
            this.autor = autor;
            this.editorial = editorial;
            this.estado = estado;
        }
        public string getTitulo()
        {
            return titulolibro;
        }
        public void setTitulo(string titulo)
        {
            this.titulolibro = titulo;
        }
        public string getAutor()
        {
            return autor;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string getEditorial()
        {
            return editorial;
        }
        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public override string ToString()
        {
            return "Titulolibro" + titulolibro + "Autor" + autor + "editorail " + editorial + "Estado" + estado;
        }


    }
    enum Estado
    {
        Nuevo, seminuevo, viejo
    }
}
