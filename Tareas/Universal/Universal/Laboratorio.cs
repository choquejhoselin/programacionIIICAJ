using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Laboratorio : Aula
    {
        public List<Computadora> listacomputadoras;

        public Laboratorio(List<Computadora> listacomputadoras)
        {
            this.listacomputadoras = listacomputadoras;
        }

        public override string getDatos()
        {
            String aux = "";
            for (int i = 0; i < listacomputadoras.Count; i++)
                aux = aux + listacomputadoras.ElementAt(i);
            return "Laboratorio:" + codigo + "Ubicacion:" + ubicacion + aux;

        }

    }
}
