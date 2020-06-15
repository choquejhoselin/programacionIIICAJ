using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Serviciocliente
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int opcion = 0;
            

            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("1. sumar");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicar");
                Console.WriteLine("4. division");
                Console.WriteLine("5. potencia");
                Console.WriteLine("6. raiz");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Elija opcion");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe primer numero");
                Double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Escribe segunco numero");
                Double b = double.Parse(Console.ReadLine());
                double c = 0;
                switch (opcion)
                {
                    case 1:
                        c = clientesincrono.getInstancia().calcularoperacion("sumar", a, b);
                       
                        Console.WriteLine("la sumas es {0}",c);
                        break;
                    case 2:

                       c=clientesincrono.getInstancia().calcularoperacion("restar", a, b);
                        Console.WriteLine("la sumas es {0}", c);
                        break;
                    case 3:
                        c=clientesincrono.getInstancia().calcularoperacion("multiplicar", a, b);
                        Console.WriteLine("la sumas es {0}", c);
                        break;
                    case 4:


                        c=clientesincrono.getInstancia().calcularoperacion("dividir", a, b);
                        Console.WriteLine("la sumas es {0}", c);
                        break;
                    case 5:
                       c= clientesincrono.getInstancia().calcularoperacion("potencia", a, b);
                        Console.WriteLine("la sumas es {0}", c);
                        break;
                    case 6:
                       c= clientesincrono.getInstancia().calcularoperacion("raiz", a, b);
                        Console.WriteLine("la sumas es {0}", c);

                        break;
                    
                }
                Console.ReadKey();
            }
        }
    }
}
