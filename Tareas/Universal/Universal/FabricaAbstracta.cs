using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    interface FabricaAbstracta
    {
        Persona getPersona(string Tipo);
        Aula getAula(string Tipo, List<Computadora> lista);
    }
}
