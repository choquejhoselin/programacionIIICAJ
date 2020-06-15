using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ParqueoMovil
{
    [Activity(Label = "ActividadMostrar")]
    public class ActividadMostrar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Mostrar);

            RecyclerView mostrar = FindViewById<RecyclerView>(Resource.Id.recyclerView1);

            
            LinearLayoutManager manager = new LinearLayoutManager(this);
            mostrar.SetLayoutManager(manager);
            Adaptador adapter = new Adaptador(Parqueo.getInstancia().getDatos());
            mostrar.SetAdapter(adapter);
            Button sal = FindViewById<Button>(Resource.Id.BCerrar);
            sal.Click += (sender, e) =>
            {

                Finish();

            };
            //Create your application here
        }
    }
}