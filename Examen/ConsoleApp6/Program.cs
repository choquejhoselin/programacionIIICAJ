using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               2, 3, 4, Mayor(3, 4, 2));
            Console.WriteLine("segundoMayor de {0}, {1} y {2} es {2}\n",
                       2, 3, 4, Segundomayor(3, 2, 4));

            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               3.1, 4.6, 2.3, Mayor(2.3, 4.6, 3.1));
            Console.WriteLine("segundoMayor de {0}, {1} y {2} es {2}\n",
              3.1, 4.6, 2.3, Segundomayor(3.1, 4.6, 2.3));

            Console.WriteLine("Mayor de {0}, {1} y {2} es {3}\n",
               "Juan", "Pedro", "Maria", Mayor("Juan", "Pedro", "Maria"));
            Console.WriteLine("segundoMayor de {0}, {1} y {2} es {2}\n",
           "Juan", "Pedro", "Maria", Segundomayor("Juan", "Pedro", "Maria"));
            Console.ReadKey();
        }

        private static T Mayor<T>(T x, T y, T z)
            where T : IComparable<T>
        {
            T max = x; 
            
            if (y.CompareTo(max) > 0)
                max = y;
       
           if (z.CompareTo(max) > 0)
                max = z; 
            return max; 
        }

        private static W Segundomayor<W>(W a, W b, W c )
            where W: IComparable<W>
        {
            W med = a;
            if (b.CompareTo(med) <0)
                med = b;
            if (c.CompareTo(med) <0)
                med = c;
            return med;
        }


    }
}
