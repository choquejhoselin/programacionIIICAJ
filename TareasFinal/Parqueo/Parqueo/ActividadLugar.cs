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
    [Activity(Label = "ActividadLugar")]
    public class ActividadLugar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Lugarxml);
            Button cerrar = FindViewById<Button>(Resource.Id.BCerrar);
            cerrar.Click += (sender, e) =>
            {

                Finish();

            };

            string mensaje = Intent.GetStringExtra("lugar");

            TextView TLugar = FindViewById<TextView>(Resource.Id.textLugar);
            TLugar.Text = mensaje;

            // Create your application here
        }
    }
}