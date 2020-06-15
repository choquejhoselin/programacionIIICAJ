using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                int n;
                Biblioteca A = Biblioteca.getInstance();
                String F;
            

                Console.Clear();
                Console.WriteLine("1:Ingresar libro");
                Console.WriteLine("2:Retirar libro");
                Console.WriteLine("3:Mostrar");
                Console.WriteLine("4:Salir");

                Console.Write("Digite un valor entre 1-4");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                string estadolibro1 = null;
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Titulo del libro");
                        string titulo = Console.ReadLine();

                        Console.WriteLine("Autor");
                        string autor = Console.ReadLine();

                        Console.WriteLine("Editorial");
                        string editorial = Console.ReadLine();

                        Console.WriteLine("Estado del libro");
                     
                        string estadolibro = Console.ReadLine();
                        estadolibro = estadolibro1;
                        Enum.TryParse(estadolibro, out estadolibro1);
                        libro x = new libro(titulo, autor, editorial,estadolibro);
                        Console.ReadKey();
                      
                        break;
                    case 2:
                        F.imprimir();
                        Console.ReadKey();
                        break;

                       
                    case 3:
                        Console.Clear();
                    
                        break;

                }
               
                   

            } while (opcion != 4);

        }
    }
}
