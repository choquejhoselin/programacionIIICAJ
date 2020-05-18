using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Singleobjects
    {
        private static Singleobjects instance;
        private String a;

        private Singleobjects()
        {

        }
        public static Singleobjects getInstance()
        {
            if (instance == null)
            {
                instance = new Singleobjects();
                return instance;
            }
            else
                return instance;

        }
        public void seta(String valor)
        {
            a = valor;
        }
        public void showMessage()
        {
            Console.WriteLine("hola singleton: " + a);
        }
    }
}
