using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorEFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int o;
            int opcion = 0;
            do
            {

                string M;




                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Remover ");
                Console.WriteLine("3. Mostrar");

                Console.WriteLine("digite un numero entre 1 - 4");


                o = int.Parse(Console.ReadLine());
                switch (o)
                {
                    case 1:

                        Console.WriteLine("Introduzca titulo del libro:");
                        string titulodellibro = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre del Autor:");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Introduzca Nombre de la Editorial");
                        string editorial = Console.ReadLine();
                        Console.WriteLine("Introduzca El estado del libro");
                        string estadodellibro = Console.ReadLine();



                        M = Cliente.GetInstance().lista(titulodellibro, autor, editorial, estadodellibro);


                        break;
                    case 2:

                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.WriteLine("Libro fue removido");
                        break;
                    case 3:



                        break;

                }

            } while (opcion != 4);
            Console.ReadKey();
        }
    }
    
}
