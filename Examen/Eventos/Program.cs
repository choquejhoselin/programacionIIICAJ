using System;

namespace Eventos
{
    public class Operaciones
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplostres; 
        public int Multiplicar(int x, int y, int z)
        {
            int iMultiplicar = x * y*z ;
            if ((iMultiplicar % 2 == 0) && (CuandoRecibaMultiplostres != null)) 
            { CuandoRecibaMultiplostres(iMultiplicar); }
            return iMultiplicar;
        }
    }
    class ProgramaEvento
    {
            static void Main()
            {
                Operaciones o = new Operaciones();
                o.CuandoRecibaMultiplostres+= RecibeMultiploTres;
                o.CuandoRecibaMultiplostres += RecibemultiploTres2;
                 o.CuandoRecibaMultiplostres += RecibemultiploTres3;
            int a,b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                int res = o.multiplicar(a, b,c);
                Console.WriteLine("La multiplicacion es = {0}", res);
                Console.ReadKey();
            }
            static void RecibeMultiploTres (int n) // Manejador de Evento
            {
                Console.WriteLine("Se obtuvo un multiplo de tres valor: {0}",n);
            }
            static void RecibemultiploTres2 (int n) // Manejador de Evento
            {
            Console.WriteLine("otro tres valor: {0}", n);
            }
          static void RecibemultiploTres3(int n) // Manejador de Evento
          {
            Console.WriteLine("otro tres valor: {0}", n);
          }
    }

    
}
