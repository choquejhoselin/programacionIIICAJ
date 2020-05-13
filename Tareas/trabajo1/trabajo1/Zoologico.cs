using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class Zoologico 
    {
        protected string nombre;
        List<Jaula> jaulas;
        List<Acuario> acuarios;
        List<Aviario> aviarios;



        protected string direccion;
        protected int telrfono;
        

        public Zoologico(string nombre,  string direccion, int telefono)
        {
            this.nombre = nombre;
            jaulas = new List<Jaula>();
            aviarios = new List<Aviario>();
            acuarios = new List<Acuario>();
            this.direccion = direccion;
            this.telrfono = telefono;
        }
        public void anadirMamifero(Mamiferos animal,double alto,double ancho,double largo)
        {
            jaulas.Add(new Jaula(animal, alto, ancho, largo));
        }
        public void anadirAves(Aves ave, double alto, double ancho, double largo)
        {
            aviarios.Add(new Aviario(ave, alto, ancho, largo));
        }
        public void anadirAcuario(Pezes pezes, double alto, double ancho, double largo)
        {
            acuarios.Add(new Acuario(pezes, alto, ancho, largo));
        }

        public void imprimir()
        {

            Console.WriteLine(" animasl: " + this.nombre + "tipo: " + this.jaulas);
            Console.WriteLine(" animasl: " + this.nombre + "tipo: " + this.acuarios);
            Console.WriteLine(" animasl: " + this.nombre + "tipo: " + this.aviarios);


        }

       

    }


}
