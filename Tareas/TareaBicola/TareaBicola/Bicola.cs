using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBicola
{
    class Bicola<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = 0;
        private int frente = 0;
        public void Insertar(T valor)
        {
            if (!LLena())
            {
                arreglo[final] = valor;
                final = (final + 1) % Maximo;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void InsertarporDelante(T valor)
        {
            if (LLena())
            {
                arreglo[frente] = valor;
                frente = (frente + 1) % Maximo;
            }
        }
        public T Eliminar()
        {
            if (!Vacia())
            {
                T valor;
                valor = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public T EliminarFinal()
        {
            if (!Vacia())
            {
                T valor;
                valor = arreglo[final];
                final = (final + 1) % Maximo;
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[final];
            }
        }
        public void mostrar()
        {
            int aux = frente;
            while (aux != final)
            {
                Console.Write(arreglo[aux] + " ");
                aux = (aux + 1) % Maximo;
            }
        }
        private Boolean Vacia()
        {
            return frente == final;
        }
        private Boolean LLena()
        {
            return frente == (final + 1) % Maximo;
        }
    }
}
