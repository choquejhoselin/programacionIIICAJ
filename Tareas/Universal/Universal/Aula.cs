using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
     abstract class Aula
    {
        protected String codigo;
        protected Ubicacion ubicacion;
        protected Tamaño tamano;
        protected int CantidadPuestos;

        public void setDatos(string codigo, Ubicacion ubicacion, Tamaño tamano, int cantidadPuestos)
        {
            this.codigo = codigo;
            this.ubicacion = ubicacion;
            this.tamano = tamano;
            CantidadPuestos = cantidadPuestos;
        }

        abstract public String getDatos();
    }
}
