using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3Examennn
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto paracetamol = new Producto("paracetamol", 1);
            Producto mentisan = new Producto("mentisan", 3);
            Producto digestan = new Producto("digigestan", 2);

            ProductoCompuesto simple = new ProductoCompuesto("Simple", 0);
            simple.insertarIngrediente(paracetamol);
            simple.insertarIngrediente(paracetamol);
            simple.insertarIngrediente(digestan);

            ProductoCompuesto tiras = new ProductoCompuesto("Simple", 0);
            tiras.insertarIngrediente(paracetamol);
            tiras.insertarIngrediente(digestan);
            tiras.insertarIngrediente(digestan);


            OrdenCompra gammerOrden = new OrdenCompra(1, "Jhoselin");
            gammerOrden.insertarProducto(tiras);
            gammerOrden.insertarProducto(digestan);
            gammerOrden.imprimirOrden();

            OrdenCompra gammerOrden2 = new OrdenCompra(1, "Danna");
            gammerOrden2.insertarProducto(simple);
            gammerOrden2.insertarProducto(paracetamol);
            gammerOrden2.imprimirOrden();

            Console.ReadKey();

        }
    }
   
}
