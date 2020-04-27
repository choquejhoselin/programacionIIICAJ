using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTIPO
{
    class Celular
    {
        Marca marca;
        string Modelo;
        TamañoPantalla tamañopantalla;
        Color color;
        int memoria;
        Procesador procesador;
        public Celular(Marca marca, string modelo, TamañoPantalla tamañopantalla, Color color, int memoria, Procesador procesador  )
        {
            this.marca = marca;
            Modelo = modelo;
            this.tamañopantalla = tamañopantalla;
            this.color = color;
            this.memoria = memoria;
            this.procesador = procesador;

        }
        public override string ToString()
        {
            return marca + Modelo + tamañopantalla + color + memoria + procesador;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

    }
    enum Marca
    {
        Nokia, LG
    }
    enum Color
    {
        Rojo, Negro, Plateado
    }
}
