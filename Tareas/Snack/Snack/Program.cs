using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snack
{
    class Program
    {
        static void Main(string[] args)
        {

            IngredienteSimple tomate = new IngredienteSimple("tomate",4);
            IngredienteSimple carne = new IngredienteSimple( "carne",4 );
            


            IngredienteSimple lechuga = new IngredienteSimple("lechigua", 0.5);
            IngredienteSimple tocino = new IngredienteSimple("tocino", 2);

            IngredienteSimple soda = new IngredienteSimple("soda", 2);
            IngredienteSimple papasfritas = new IngredienteSimple("papasfritas", 1.5);

            IngredienteSimple queso = new IngredienteSimple("queso", 1 );



            ProductoCompuesto simple = new ProductoCompuesto("Simple");
            simple.insertarIngrediente(carne);
            simple.insertarIngrediente(tomate);
            simple.insertarIngrediente(lechuga);



            ProductoCompuesto HSimple = new ProductoCompuesto("de queso");
            HSimple.insertarIngrediente(carne);
            HSimple.insertarIngrediente(tomate);
            HSimple.insertarIngrediente(lechuga);
            HSimple.insertarIngrediente(queso);

            ProductoCompuesto hamburguesaD = new ProductoCompuesto("de queso");
            hamburguesaD.insertarIngrediente(carne);
            hamburguesaD.insertarIngrediente(carne);
            hamburguesaD.insertarIngrediente(tomate);
            hamburguesaD.insertarIngrediente(lechuga);
            hamburguesaD.insertarIngrediente(queso);

            ProductoCompuesto hamburguesaT = new ProductoCompuesto("de queso");
            hamburguesaT.insertarIngrediente(carne);
            hamburguesaT.insertarIngrediente(tocino);
            hamburguesaT.insertarIngrediente(tomate);
            hamburguesaT.insertarIngrediente(lechuga);
            hamburguesaT.insertarIngrediente(queso);

           
            ProductoCompuesto h2x1 = new ProductoCompuesto("COMBO 1");
            h2x1.insertarIngrediente(simple);
            h2x1.insertarIngrediente(soda);
            h2x1.insertarIngrediente(papasfritas);

            ProductoCompuesto c2 = new ProductoCompuesto("COMBO 2");
            c2.insertarIngrediente(queso);
            c2.insertarIngrediente(queso);
            c2.insertarIngrediente(papasfritas);

            ProductoCompuesto SC = new ProductoCompuesto("SUPER COMBO");
            SC.insertarIngrediente(h2x1);
            SC.insertarIngrediente(c2);

            OrdenCompra gammerOrden = new OrdenCompra(1, "Maria Vallejos ");
            gammerOrden.insertarProducto(h2x1);
            gammerOrden.imprimirOrden();

            OrdenCompra casaOrden = new OrdenCompra(2, " Mario Loaiza ");
            casaOrden.insertarProducto(SC);
            casaOrden.imprimirOrden();

            OrdenCompra comboOrden = new OrdenCompra(3, "Paquete 2x1 en PC");
            comboOrden.insertarProducto(simple);
            comboOrden.imprimirOrden();

            OrdenCompra personalizadoOrden = new OrdenCompra(4, " Roberto Callejas ");
            personalizadoOrden.insertarProducto(simple);
            personalizadoOrden.insertarProducto(soda);
            personalizadoOrden.insertarProducto(soda);
            personalizadoOrden.insertarProducto(SC);
            personalizadoOrden.insertarProducto(papasfritas);
            personalizadoOrden.imprimirOrden();

            Console.ReadKey();

        }
    }
}
