using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPregunta1
{
    class ClaseAbstracta
    {

        novela GetNovela(string titulo, string autor, string genero);
        revista GetEntrevista(string titulo, int nropagina);
       Enciclopedia GetEnciclopedia(string nombre, string editorial, string tema);

    }
}
