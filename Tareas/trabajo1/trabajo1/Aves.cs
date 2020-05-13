using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    abstract class Aves
    {
        protected string nombre;
        protected double peso;
        protected double tamañodeala;

        public Aves(string nombre, double peso, double tamañodeala)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.tamañodeala = tamañodeala;
        }
        public override string ToString()
        {
            return "nombre: " + nombre + "peso: " + peso + "tamaño de su ala" +tamañodeala;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public double getPeso()
        {
            return peso;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getTamañodeala()
        {
            return tamañodeala;
        }
        public void setTamañodeala(double tamañodeala)
        {
            this.tamañodeala = tamañodeala;
        }
    }
}
