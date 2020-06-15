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
    [Activity(Label = "ActividadSalida")]
    public class ActividadSalida : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Salida);
            EditText TPlacaSalida = FindViewById<EditText>(Resource.Id.editPlacaSalida);
            Button BSalida = FindViewById<Button>(Resource.Id.BSalida1);
            TextView TSalida = FindViewById<TextView>(Resource.Id.textMostrarSalida);

            BSalida.Click += (sender, e) =>
            {
                string placaSalida = TPlacaSalida.Text;

                
                
                string mensaje = Parqueo.getInstancia().SalirAuto(placaSalida);
                
                TSalida.Text = mensaje;
            };

                // Create your application here
            }
    }
}