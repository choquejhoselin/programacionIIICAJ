using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    class IngredienteSimple:AbstractProducto
    {
        protected double precio;

        public IngredienteSimple( string nombre, double precio)
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
