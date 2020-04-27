using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class FabricaAula : FabricaAbstracta
    {
        public Aula getAula(string Tipo, List<Computadora> lista)
        {
            switch (Tipo)
            {
                case "teoria":
                    return new Teoria();
                case "laboratorio":
                    return new Laboratorio(lista);

                default:
                    return null;

            }
        }



        public Persona getPersona(string Tipo)
        {
            throw new System.NotImplementedException();
        }
    }
}
