using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3Examennn
{
    class ProductoCompuesto :AbstractProducto
    {
        private List<AbstractProducto> componentes = new List<AbstractProducto>();



        protected double descuento;

        public ProductoCompuesto(String nombre, double descuento)
        {
            this.nombre = nombre;
            this.descuento = descuento;

        }


        public void insertarIngrediente(AbstractProducto componente)
        {
            this.componentes.Add(componente);
        }

        public bool eliminarProductos(AbstractProducto producto)
        {
            return this.componentes.Remove(producto);
        }

        public override double getPrecio()
        {
            double precio = 0;
            foreach (AbstractProducto producto in componentes)
            {
                precio += producto.getPrecio();

            }
            precio = precio - descuento;
            return precio;

        }
    }
}

