using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_lambda
{
    public delegate double[] Delegado(int a, int b, int c);
    class Program
    {

        static void Main(string[] args)
        {


            Delegado del = (int a, int b, int c) =>
            {
                double[] aux = new double[2];
                double discriminante = Math.Pow(b, 2) - 4 * a * c;
                aux[0] = (-b + Math.Sqrt(discriminante)) / 2 * a;
                aux[1] = (-b - Math.Sqrt(discriminante)) / 2 * a;
                return aux;
            };

            //int n = int.Parse(Console.ReadLine());

            double[] raices = del(1, 5, 4);
            Console.WriteLine("x1 ={0}", raices[0]);
            Console.WriteLine("x2 ={0}", raices[1]);
            Console.ReadKey();
        }
    }
}
