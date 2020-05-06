using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    class OrdenCompra
    {
        private long idOrden;
        private String cliente;
        private Calendar fecha;
        private List<AbstractProducto> listaProductos;

        public OrdenCompra(long idOrden, string cliente)
        {
            this.idOrden = idOrden;
            this.cliente = cliente;
            listaProductos = new List<AbstractProducto>();
            
        }

        public long getidOrden()
        {
            return idOrden;
        }

        public void setidOrden(long idOrden)
        {
            this.idOrden = idOrden;
        }

        public String getCliente()
        {
            return cliente;
        }

        public void setCliente(String cliente)
        {
            this.cliente = cliente;
        }

        public Calendar getFecha()
        {
            return fecha;
        }

        public void setDateTime(Calendar fecha)
        {
            this.fecha = fecha;
        }

        public List<AbstractProducto> getProductos()
        {
            return listaProductos;
        }

        public void setProductos(List<AbstractProducto> listaproductos)
        {
            this.listaProductos = listaproductos;
        }

        public double getPrecio()
        {

            double precio = 0;
            foreach (AbstractProducto producto in listaProductos)
            {
                precio += producto.getPrecio();
            }
            return precio;
        }

        public void insertarProducto(AbstractProducto combo)
        {
            listaProductos.Add(combo);
        }

        public void eliminarProducto(AbstractProducto combo)
        {
            listaProductos.Remove(combo);
        }

        public void imprimirOrden()
        {

            Console.WriteLine(".....................................nOrden: " + idOrden + "nCliente: " + cliente);
            foreach (AbstractProducto producto in listaProductos)
            {

                Console.WriteLine("{0}               {1}", producto.getNombre(), producto.getPrecio());

            }
            Console.WriteLine("Total: {0} .......................................", getPrecio());
        }
    }
}
