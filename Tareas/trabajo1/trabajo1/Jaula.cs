using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class Jaula
    {
        protected Mamiferos animal;
        protected double alto;
        protected double ancho;
        protected double largo;

        public Jaula(Mamiferos animal, double alto, double ancho, double largo)
        {
            this.animal = animal;
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }
        public Mamiferos getAnimal()
        {
            return animal;
        }
        public void setAnimal(Mamiferos animal)
        {
            this.animal = animal;
        }

        public double getAlto()
        {
            return alto;
        }
        public void setAlto(double alto)
        {
            this.alto = alto;
        }
        public double getAncho()
        {
            return ancho;
        }
        public void setAncho(double ancho)
        {
            this.ancho = ancho;
        }

        public double getLargo()
        {
            return largo;
        }
        public void setLargo(double largo)
        {
            this.largo = largo;
        }

    }
}
