using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Computadora : ICloneable
    {
        Marca marca;
        string modelo;
        Procesador procesador;
        List<DiscoDuro> discos;
        Color color;
        int aniofabricacion;

        public Computadora(Marca marca, string modelo, Procesador procesador, List<DiscoDuro> discos, Color color, int aniofabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.procesador = procesador;
            this.discos = discos;
            this.color = color;
            this.aniofabricacion = aniofabricacion;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return marca.ToString() + modelo.ToString() + procesador.ToString();
        }
    }
    enum Marca
    {
        Dell,
        Hp,
        Lenovo
    }
    enum Color
    {
        negro, blanco, plomo
    }
}
