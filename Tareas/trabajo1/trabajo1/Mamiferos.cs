using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    abstract class Mamiferos
    {
        protected string nombre;
        protected double temperatura;
        protected double ndepatas;
        protected Color color;

        public Mamiferos(string nombre, double temperatura, double ndepatas)
        {
            this.nombre = nombre;
            this.temperatura = temperatura;
            this.ndepatas = ndepatas;

        }

        
            

      

        public override string ToString()
        {
            return "nombre: "  + nombre + "temperatura: " + temperatura + "ndepatas: " + ndepatas ;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double getTemperatura()
        {
            return temperatura;
        }
        public void setTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double getNdepatas()
        {
            return ndepatas;
        }
        public void setNdepatas(double ndepatas)
        {
            this.ndepatas = ndepatas;
        }
        public Color getColor()
        {
            return color;
        }
        public void setColor(Color color)
        {
            this.color = color ;
        }
    }
    enum Color
    {
        rojo, blancos, cafes, negro
    }
}
