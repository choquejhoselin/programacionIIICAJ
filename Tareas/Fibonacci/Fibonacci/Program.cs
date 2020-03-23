using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        private static readonly int n;

        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Numero fibonacci");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El fibonacci recursivo es" + FibonacciRecursivo(numero));

            Console.ReadKey();
        }

        static int FibonacciRecursivo(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

    }
}
