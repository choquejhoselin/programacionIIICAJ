using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBicola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            Bicola<int> p = new Bicola<int>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar frente");
                Console.WriteLine("2. Insertar detras ");
                Console.WriteLine("3. Eliminar delante");
                Console.WriteLine("4. Eliminar detras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento por adelante");
                        x = int.Parse(Console.ReadLine());
                        p.Insertar(x);
                        break;
                    case 2:
                        Console.WriteLine("introduzca un elemento por detras");
                        x = int.Parse(Console.ReadLine());
                        p.Insertar(x);
                        break;
                    case 3:
                        x = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 4:
                        x = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }   

   
}
