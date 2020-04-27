using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Teoria : Aula
    {

        List<string> pupitres;
        public override string getDatos()
        {
            return "Teoria:" + codigo + "Ubicacion:" + ubicacion;

        }
    }
}
