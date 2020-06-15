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
    [Activity(Label = "ActividadInsertar")]
    public class ActividadInsertar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Ingresar);

            RadioGroup RTipo = FindViewById<RadioGroup>(Resource.Id.radioTipo);
            RadioGroup RColor = FindViewById<RadioGroup>(Resource.Id.radioColor);
            RadioGroup RMarca = FindViewById<RadioGroup>(Resource.Id.radioMarca);
            EditText TPlaca = FindViewById<EditText>(Resource.Id.editPlaca);
            Button BIngresa = FindViewById<Button>(Resource.Id.BIngresar1);



            BIngresa.Click += (sender, e) =>
            {

                int seleccionadoTipoID = RTipo.CheckedRadioButtonId;
                RadioButton seleccionadoTipo = FindViewById<RadioButton>(seleccionadoTipoID);
                Tipo tipo;
                string strTipo = seleccionadoTipo.Text;
                Enum.TryParse(strTipo, out tipo);

                int seleccionadoColorID = RColor.CheckedRadioButtonId;
                RadioButton seleccionadoColor = FindViewById<RadioButton>(seleccionadoColorID);
                Color color;
                string strColor = seleccionadoColor.Text;
                Enum.TryParse(strColor, out color);

                int seleccionadoMarcaID = RMarca.CheckedRadioButtonId;
                RadioButton seleccionadoMarca = FindViewById<RadioButton>(seleccionadoMarcaID);
                Marca marca;
                string strMarca = seleccionadoMarca.Text;
                Enum.TryParse(strMarca, out marca);

                string placa = TPlaca.Text;

                string lugar = Parqueo.getInstancia().ingresarAuto(color, marca, tipo, placa);

                var lugr = new Intent(this, typeof(ActividadLugar));
                lugr.PutExtra("lugar", lugar);
                StartActivity(lugr);
            };




            // Create your application here
        }
    }
}