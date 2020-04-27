using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadadecontagiados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            ListaDouble l = new ListaDouble();

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

                        Console.Write("Introduzca el Nombre: ");
                        String Nombre = Console.ReadLine();
                        Console.Write("Introduzca el Primer Apellido: ");
                        String PrimerApellido = Console.ReadLine();

                        String segundoApellido = Console.ReadLine();
                        Console.Write("Introduzca estado : ");
                        String localidad = Console.ReadLine();
                        Console.Write("Introduzca el Sexo: (M/F) ");
                        String sexo = Console.ReadLine();

                        Console.Write("Introduzca la Edad: ");
                        int edad = int.Parse(Console.ReadLine());

                        Infectado a = new Infectado(Nombre, PrimerApellido, segundoApellido, localidad, sexo, edad);

                        l.Insertar(a);
                        break;
                    case 2:
                        Console.WriteLine("que apellido quiere eliminar");
                        string x = (Console.ReadLine());
                        l.EliminarApellido(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
