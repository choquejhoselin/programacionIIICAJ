using System;

namespace Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;



            Aritmetica x = Aritmetica.getInstance();

            do
            {

                Console.WriteLine("1. sumar");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicar");
                Console.WriteLine("4. division");
                Console.WriteLine("5. potencia");
                Console.WriteLine("6. raiz");
                Console.WriteLine("7. Salir");
                
                //opcion = int.Parse(Console.ReadLine());
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe primer numero");
                Double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Escribe segunco numero");
                Double b = double.Parse(Console.ReadLine());

                

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1. la suma es");

                        Console.WriteLine(x.suma(a, b));
                        break;
                    case 2:

                        Console.WriteLine("1. la resta es");

                        Console.WriteLine(x.resta(a, b));
                        break;
                    case 3:
                        Console.WriteLine("1. la multiplicacion es");

                        Console.WriteLine(x.multiplicacion(a, b));
                        break;
                    case 4:

                        Console.WriteLine("1. la division es");

                        Console.WriteLine(x.division(a, b));
                        break;
                    case 5:
                        Console.WriteLine("1. la potencia es");

                        Console.WriteLine(x.potencia(a, b));
                        break;
                    case 6:
                        Console.WriteLine("1. la raiz es");

                        Console.WriteLine(x.raiz(a, b));

                        break;

                }

            } while (opcion != 7);



        }
    }
}
