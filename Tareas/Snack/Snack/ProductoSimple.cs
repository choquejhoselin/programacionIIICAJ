using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    class ProductoSimple:AbstractProducto
    {
        protected String marca;

        public ProductoSimple(string nombre, double precio, string cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = cantidad;
        }

        public String getMarca()
        {
            return marca;
        }

        public override double getPrecio()
        {
            return this.precio;
        }

        public void setMarca(String cantidad)
        {
            this.marca = cantidad;
        }
    }
}
