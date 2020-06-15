using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servidoraritmetica
{
    class Aritmetica
    {
        static Aritmetica instancia;
        private Aritmetica()
        {
        }

        public static Aritmetica getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Aritmetica();
            }
            return instancia;
        }
        public double suma(double a, double b)
        {

            return (a + b);
        }

        public double resta(double a, double b)
        {

            return (a - b);
        }

        public double producto(double a, double b)
        {


            return (a * b);
        }

        public double division(double a, double b)
        {


            return (a / b);
        }
        public double potencia(double a, double b)
        {


            return Math.Pow(a, b);


        }
        public double raiz(double a, double b)
        {

            return Math.Pow(a, (1 / b));

        }
    }
}
