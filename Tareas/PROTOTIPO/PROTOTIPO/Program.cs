using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTIPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular a = new Celular(Marca.LG, "G8", new TamañoPantalla(10, 6), Color.Negro, 16 , new Procesador("  Snapdragon 855 (8 núcleos)   ", 7, 3 ));
            Celular b = (Celular)a.Clone();
            Celular b1 = (Celular)a.Clone();
            Celular b2= (Celular)a.Clone();
            Celular b3 = (Celular)a.Clone();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
