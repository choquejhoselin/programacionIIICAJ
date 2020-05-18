using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class SigletonPatternDemo
    {
        static void Main(string[] args)
        {
            Singleobjects uno = Singleobjects.getInstance();
            uno.seta("La ciudad es");
            uno.showMessage();
            Singleobjects dos = Singleobjects.getInstance();
            dos.seta("La temperatura es: ");
            uno.showMessage();
            Console.ReadKey();
        }
    }
}
