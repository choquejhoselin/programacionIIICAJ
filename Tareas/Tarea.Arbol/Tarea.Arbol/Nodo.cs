using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea.Arbol
{
    class Nodo
    {
        public string info { set; get; }
        public Nodo izq;
        public Nodo der;

        public Nodo(string info)
        {
            this.info = info;                       '0
        }
    }
}
