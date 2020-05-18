using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            pila<Libros> p = new pila<Libros>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Novela, revista, enciclopedia ");
                        String nombredelibro = Console.ReadLine();
                        Console.WriteLine("introduzca Autor");
                        String autor = Console.ReadLine();
                        Console.WriteLine("introduzca editorial");
                        String editorial = Console.ReadLine();
                        Console.WriteLine("introduzca Año de publicacion");
                        int añodepublicacion = int.Parse(Console.ReadLine());

                        Libros x = new Libros(nombredelibro, autor, editorial, añodepublicacion);
                        p.push(x);
                        break;
                    case 2:
                        Libros y = p.pop();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }

        }

        private class Libros
        {
            private string nombredelibro;
            private string autor;
            private string editorial;
            private int añodepublicacion;

            public Libros(string nombredelibro, string autor, string editorial, int añodepublicacion)
            {
                this.nombredelibro = nombredelibro;
                this.autor = autor;
                this.editorial = editorial;
                this.añodepublicacion = añodepublicacion;
            }
        }
    }
    
}
