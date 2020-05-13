using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1
{
    class FabricaAves : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamañodeala)
        {
            switch (Tipo)
            {
                case "pacu":
                    return new Loro(nombre, peso,tamañodeala);
                case "Sabalo":
                    return new Condor(nombre, peso, tamañodeala);


                default:
                    return null;

            }
        }

        public Mamiferos getMamifero(string Tipo, string nombre, double temperatura, double ndepatas)
        {
            throw new NotImplementedException();
        }

        public Pezes getPezes(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
