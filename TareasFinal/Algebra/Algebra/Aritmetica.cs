using System;
using System.Collections.Generic;
using System.Text;

namespace Algebra
{
    class Aritmetica
    {
        static Aritmetica instance;
        private Aritmetica()
        {
        }

        public static Aritmetica getInstance()
        {
            if (instance == null)
            {
                instance = new Aritmetica();
                return instance;
            }
            
                return instance;

        }
        public double suma (double a, double b)
        {
            return a + b;

        }
        public double resta(double a, double b)
        {
            return a - b;

        }
        public double multiplicacion(double a, double b)
        {
            return a * b;

        }
        public double division(double a, double b)
        {
            return a / b;

        }
        public double raiz(double a, double b)
        {
            return Math.Pow(a,(1/b));

        }
        public double potencia(double a, double b)
        {
            return Math.Pow(a,b);

        }









    }
}
