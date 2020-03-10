using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaN2
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double y char
            int[] intArray = { 3, 6, 1, 4, 2, 5 };
            double[] doubleArray = { 4.1, 1.2, 1.1, 2.4, 6.5, 3.6, 7.7 };
            char[] charArray = { 'J', 'H', 'O', 'S' };

            Console.WriteLine("Arreglo inicial:");
            Mostrar(intArray);
            Console.WriteLine("Arreglo ordenado:");
            Ordenar(intArray);
            Mostrar(intArray);
            Console.WriteLine("Arreglo inicial:");
            Mostrar(doubleArray);
            Console.WriteLine("Arreglo ordenado:");
            Ordenar(doubleArray);
            Mostrar(doubleArray);
            Console.WriteLine("Arreglo inicial:");
            Mostrar(charArray);
            Console.WriteLine("Arreglo ordenado:");
            Ordenar(charArray);
            Mostrar(charArray);

            Console.ReadKey();
        }
        private static void Mostrar<T>(T[] arreglo)
        {
            foreach (T element in arreglo)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
        private static void Ordenar<T>(T[] a)
            where T : IComparable<T>
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1 - j; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                    {
                        T aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                }
            }
        }
    }
}
