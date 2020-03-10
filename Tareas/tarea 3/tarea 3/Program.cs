using System;

namespace tareaEventos
{
    public class Operacionesvector 
    {
        public delegate void Delegado(int[] arreglo); 
        public event Delegado CuandoseIntroduce1; 
        public void Llenar(int[] arreglo)
        {
            Console.WriteLine("Introduzca valores");
            for (int i = 0; i < 5; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
                if ((arreglo[i] == -1) && (CuandoseIntroduce1 != null))
                {
                    CuandoseIntroduce1(arreglo);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            Operacionesvector op = new Operacionesvector();
            op.CuandoseIntroduce1 += MostrarVector;
            op.Llenar(arreglo);
        }
        static void MostrarVector(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}

