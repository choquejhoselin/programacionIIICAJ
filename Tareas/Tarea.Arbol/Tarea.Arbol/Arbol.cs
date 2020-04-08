using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Arbol
{
    class Arbol
    {

        private Nodo raiz;

        public void insertar(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo aux = raiz;
                Nodo ant = null;
                while (aux != null)
                {
                    if (valor.CompareTo(aux.info) >= 0)
                    {
                        ant = aux;
                        aux = aux.der;
                    }
                    else
                    {
                        ant = aux;
                        aux = aux.izq;
                    }
                }
                // en ant tengo el nodo anterior
                if (valor.CompareTo(ant.info) >= 0)
                {
                    ant.der = nuevo;
                }
                else
                {
                    ant.izq = nuevo;
                }

                 
            }
        }
        //public string eliminar()
        //{

        //}
        private void PreOrden(Nodo aux)
        {
            if (aux != null)
            {
                Console.WriteLine(aux.info);
                PreOrden(aux.izq);
                PreOrden(aux.der);
            }

        }

        public void mostrarPreOrden()
        {
            Nodo aux = raiz;
            PreOrden(aux);
        }
        /* public string mostrarInOrden()
         {

         }
         public string mostrarPostOrden()
         {

         }
         */
    }
}
