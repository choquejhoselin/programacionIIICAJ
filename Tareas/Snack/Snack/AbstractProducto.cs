using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    abstract class AbstractProducto
    {
        protected String nombre;



        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public abstract double getPrecio();
        


    }
}
