using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladerentistas
{
    class Cola<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = -1;
        private int frente = 0;

        public void Insertar(T valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public T Eliminar()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public void mostrar()
        {
            for (int i = frente; i <= final; i++)
                Console.WriteLine(arreglo[i] + " ");

        }
        private Boolean Vacia()
        {
            return final < frente;
        }
        private Boolean LLena()
        {
            return final == Maximo;
        }

    }
}
