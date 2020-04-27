using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Ubicacion
    {

        int piso;
        int nroaula;

        public Ubicacion(int piso, int nroaula)
        {
            this.piso = piso;
            this.nroaula = nroaula;
        }

        public override string ToString()
        {
            return piso.ToString() + nroaula.ToString();
        }
    }
}
