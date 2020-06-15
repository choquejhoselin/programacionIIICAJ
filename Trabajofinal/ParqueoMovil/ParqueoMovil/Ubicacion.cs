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
    class Ubicacion
    {
        string calle;
        int numero;

        public Ubicacion(string calle, int numero)
        {
            this.calle = calle;
            this.numero = numero;
        }

        public override string ToString()
        {
            return "calle: " + calle + " # " + numero;
        }
    }
}