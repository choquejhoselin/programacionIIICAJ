using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class FabricaMamiferos : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamañodeala)
        {
            throw new NotImplementedException();
        }

        public Mamiferos getMamifero(string Tipo, string nombre, double temperatura, double ndepatas)
        {
            switch (Tipo)
            {
                case "Oso":
                    return new Oso( nombre, temperatura,  ndepatas);
                case "Mono":
                    return new Mono( nombre,  temperatura,  ndepatas);
                case "Leon":
                    return new Leon( nombre,  temperatura,  ndepatas);

                default:
                    return null;

            }
        }

        public Pezes getPezes(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
