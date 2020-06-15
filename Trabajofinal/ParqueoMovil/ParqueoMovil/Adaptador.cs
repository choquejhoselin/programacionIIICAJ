using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace ParqueoMovil
{
    class Adaptador : RecyclerView.Adapter
    {
        public event EventHandler<AdaptadorClickEventArgs> ItemClick;
        public event EventHandler<AdaptadorClickEventArgs> ItemLongClick;
        IPuesto[] items;

        public Adaptador(IPuesto[] data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            
            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.Vista;
            itemView = LayoutInflater.From(parent.Context).
                  Inflate(id, parent, false);

            var vh = new AdaptadorViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as AdaptadorViewHolder;
            holder.textvista.Text = items[position].getNumero().ToString();

            if (items[position].estaOcupado())
            {
                holder.textlibre.Text = "ocupado";
                holder.textplaca.Text = items[position].getAuto().getPlaca();
                holder.textingreso.Text = items[position].getInicio();
            }
            else
            {
                holder.textlibre.Text = "Libre";
                holder.textplaca.Text = "||";
                holder.textingreso.Text = "||";
            }

        }

        public override int ItemCount => items.Length;

        void OnClick(AdaptadorClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(AdaptadorClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class AdaptadorViewHolder : RecyclerView.ViewHolder
    {
        public TextView textvista { get; set; }
        public TextView textplaca { get; set; }
        public TextView textingreso { get; set; }
        public TextView textlibre { get; set; }
     


        public AdaptadorViewHolder(View itemView, Action<AdaptadorClickEventArgs> clickListener,
                            Action<AdaptadorClickEventArgs> longClickListener) : base(itemView)
        {

            textvista = (TextView)itemView.FindViewById(Resource.Id.textVista);
            textplaca = (TextView)itemView.FindViewById(Resource.Id.textPlaca);
            textingreso = (TextView)itemView.FindViewById(Resource.Id.textIngreso);
            textlibre = (TextView)itemView.FindViewById(Resource.Id.textLibre);
            
        }
    }

    public class AdaptadorClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}