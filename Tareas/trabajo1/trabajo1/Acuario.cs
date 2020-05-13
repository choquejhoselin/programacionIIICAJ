using System;

namespace trabajo1
{
    internal class Acuario
    {
        protected Pezes pezes;
        protected double alto;
        protected double ancho;
        protected double largo;
        public Acuario(Pezes pezes, double alto, double ancho, double largo)
        {
            this.pezes = pezes;
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }
        public Pezes getPezes()
        {
            return pezes;
        }
        public void setPezes(Pezes pezes)
        {
            this.pezes = pezes;
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

        internal static void Add(Aviario aviario)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Acuario acuario)
        {
            throw new NotImplementedException();
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