using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTOTIPO
{
    class Procesador
    {
        String Marca;
        int CantidadNucleos;
        double Frecuencia;

        public Procesador(string marca, int cantidadNucleos, double frecuencia)
        {
            Marca = marca;
            CantidadNucleos = cantidadNucleos;
            Frecuencia = frecuencia;
        }

        public override string ToString()
        {
            return Marca + CantidadNucleos.ToString() + Frecuencia.ToString();
        }
    }
}
