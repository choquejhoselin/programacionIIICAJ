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
    [Activity(Label = "ActividadHistorial")]
    public class ActividadHistorial : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Historial);

            ListView historial = FindViewById<ListView>(Resource.Id.listHistorial);
            EditText lista = FindViewById<EditText>(Resource.Id.editlist);
            Button Hist = FindViewById<Button>(Resource.Id.blist);

            Hist.Click += (sender, e) =>
            {
                int n = int.Parse(lista.Text);
                List<string> resultado = Parqueo.getInstancia().getHistorial(n);
                ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,resultado);
                historial.Adapter = adapter; 
            };   


                // Create your application here
            }
    }
}