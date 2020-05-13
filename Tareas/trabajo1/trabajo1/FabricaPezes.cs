using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class FabricaPezes : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamañodeala)
        {
            throw new NotImplementedException();
        }

        public Mamiferos getMamifero(string Tipo, string nombre, double temperatura, double ndepatas)
        {
            throw new NotImplementedException();
        }

        public Pezes getPezes(string Tipo, string nombre, double longitud)
        {
            switch (Tipo)
            {
                case "pacu":
                    return new Pacu(nombre, longitud);
                case "Sabalo":
                    return new Sabalo(nombre, longitud);
                

                default:
                    return null;

            }
        }

        
    }
}
