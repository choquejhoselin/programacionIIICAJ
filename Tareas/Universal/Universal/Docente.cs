using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Docente : Persona
    {
        public override String GetDatos()
        {
            return "Docente: " + nombres + " " + apellidos;
        }
    }
}
