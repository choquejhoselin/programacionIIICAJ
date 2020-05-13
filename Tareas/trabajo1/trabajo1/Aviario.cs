using System;

namespace trabajo1
{
     class Aviario
    {
        protected Aves ave;
        protected double alto;
        protected double ancho;
        protected double largo;
        public Aviario(Aves ave, double alto, double ancho, double largo)
        {
            this.ave = ave;
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }
        public Aves getAve()
        {
            return ave;
        }
        public void setAve(Aves ave)
        {
            this.ave = ave;
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