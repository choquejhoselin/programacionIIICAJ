using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3Examennn
{
    class Producto:AbstractProducto
    {
        protected double precio;

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;

        }


        public override double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio1)
        {
            precio = precio1;
        }

    }
}

