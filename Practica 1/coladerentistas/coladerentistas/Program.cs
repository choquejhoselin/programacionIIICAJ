using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladerentistas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            rentista x;
            Cola<rentista> a = new Cola<rentista>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca el Nombre");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("introduzca el Apellido");
                        string Apellido = Console.ReadLine();
                        Console.WriteLine("introduzca el Sexo");
                        string Sexo = Console.ReadLine();
                        Console.WriteLine("introduzca el Edad");
                        int Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca el sector");
                        string Sector = Console.ReadLine();
                        x = new rentista(Nombre,Apellido,Sexo,Edad,Sector);
                        a.Insertar(x);
                        break;
                    case 2:
                        x = a.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        a.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
