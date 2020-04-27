using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadadecontagiados
{
    class Nodo
    {
        public Infectado info;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(Infectado enfermo)
        {
            info = enfermo;
            Siguiente = null;
        }
    }
    class ListaDouble

    {
        public Nodo Actual;
        public void Insertar(Infectado enfermo)
        {
            Nodo nuevo = new Nodo(enfermo);
            if (Actual == null)
            {
                Actual = nuevo;
            }
            else
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux != null && enfermo.primerapellido.CompareTo(aux.info.primerapellido) > 0)
                {
                    ant = aux;
                    aux = aux.Siguiente;

                }
                if (ant == null)
                {
                    Actual = nuevo;
                    nuevo.Siguiente = aux;
                    aux.Anterior = nuevo;
                }
                else
                {
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                    nuevo.Anterior = ant;
                }

            }
        }
        public void EliminarApellido(string apellido)
        {
            if (Actual != null)
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux.Siguiente != null && aux.info.primerapellido != apellido)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info.primerapellido == apellido)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");


            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Elentos de la lista:");
            if (Actual != null)
            {
                Nodo aux = Actual;
                while (aux != null)
                {
                    Console.WriteLine("{0}     ", aux.info);
                    aux = aux.Siguiente;

                }
            }
        }
    }
}
