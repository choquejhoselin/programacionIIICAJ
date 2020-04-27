using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class DiscoDuro
    {
        string marca;
        int capacidad;
        MedidaCapacidad medidacapacidad;

        public DiscoDuro(string marca, int capacidad, MedidaCapacidad medidacapacidad)
        {
            this.marca = marca;
            this.capacidad = capacidad;
            this.medidacapacidad = medidacapacidad;
        }
    }
    enum MedidaCapacidad
    {
        Mb, Gb, Tb
    }
}
