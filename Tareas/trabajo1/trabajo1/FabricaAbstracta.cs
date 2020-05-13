using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    interface FabricaAbstracta
    {
        Mamiferos getMamifero(string Tipo, string nombre, double temperatura, double ndepatas);
        Aves getAves(string Tipo, string nombre, double peso, double tamañodeala);
        Pezes getPezes(string Tipo, string nombre, double longitud);
       
    }
}
