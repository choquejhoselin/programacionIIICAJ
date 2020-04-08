using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            String x = "";
            Arbol a = new Arbol();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar preoden");


                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = Console.ReadLine();
                        a.insertar(x);
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x = Console.ReadLine();
                        // l.Eliminar(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        a.mostrarPreOrden();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
