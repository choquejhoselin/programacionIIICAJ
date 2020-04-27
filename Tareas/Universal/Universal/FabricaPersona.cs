using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class FabricaPersona: FabricaAbstracta
    {
        public Aula getAula(string Tipo, List<Computadora> lista)
        {
            throw new NotImplementedException();
        }

        public Persona getPersona(string Tipo)
        {
            switch (Tipo)
            {
                case "alumno":
                    return new Alumno();
                case "docente":
                    return new Docente();
                case "adminsitrativo":
                    return new Docente();

                default:
                    return null;

            }
        }
    }
}
