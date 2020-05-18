using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    abstract class ClaseLibro : ClaseAbstracta
    {


        public Enciclopedia GetEnciclopedia(string nombre, string editorial, string tema)
        {
            throw new NotImplementedException();
        }

        public novela GetNovela(string titulo, string autor, string genero)
        {
            throw new NotImplementedException();
        }

        public revista GetRevista(string titulo, int nropagina)
        {
            throw new NotImplementedException();
        }
    }
}
