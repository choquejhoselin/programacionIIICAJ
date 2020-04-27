using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piladelibros
{
    class libro
    {
        public libro(string nombredelibro,string autor,string editorial,int añodepublicacion)
        {
            Nombredelibro = nombredelibro;
            Autor = autor;
            Editorial = editorial;
            Añodepublicacion = añodepublicacion;
        }
        public string Nombredelibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Añodepublicacion { get; set; }
       override public string ToString()
       {
            return Nombredelibro + " " + Autor + "  " + Editorial + "  " + Añodepublicacion+"  ";
       }

    }
}

