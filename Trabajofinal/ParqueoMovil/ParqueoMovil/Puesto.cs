using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ParqueoMovil
{
    class Puesto : IPuesto
    {
        protected int numero;
        protected Auto auto;
        protected DateTime inicio;
        protected DateTime fin;

        public string getInicio()
        {
            return inicio.ToString();
        }
        public int getNumero()
        {
            return numero;
        }
        public Auto getAuto()
        {
            return auto;
        }
        public Puesto(int numero)
        {
            this.numero = numero;
        }

        public string ingresarAuto(Auto auto)
        {
            this.auto = auto;
            inicio = DateTime.Now;
            return inicio.ToLongDateString();
        }

        public double salirAuto()
        {
            this.auto = null;
            fin = DateTime.Now;
            TimeSpan total = fin - inicio;
            return total.TotalHours;
        }
        public Boolean estaOcupado()
        {
            return (this.auto != null);
        }
    }
}