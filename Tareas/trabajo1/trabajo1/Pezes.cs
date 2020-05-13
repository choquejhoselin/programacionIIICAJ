using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
   abstract class Pezes
    {
        protected string nombre;
        protected double longitud;

        public Pezes(string nombre, double longitud)
        {
            this.nombre = nombre;
            this.longitud = longitud;
        }
        public override string ToString()
        {
            return "nombre: " + nombre + "longitud: " + longitud ;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double getLongitud()
        {
            return longitud;
        }
        public void setLongitud(double longitud)
        {
            this.longitud = longitud;
        }
    }
}
