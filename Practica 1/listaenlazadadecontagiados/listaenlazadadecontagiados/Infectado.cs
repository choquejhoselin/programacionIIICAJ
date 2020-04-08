using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadadecontagiados
{
    class Infectado
    {
        public Infectado(string nombre, string primerapellido, string segundoapellido, string lo, string sexo, int edad)
        {
            this.nombre = nombre;
            this.primerapellido = primerapellido;
            this.segundoapellido = segundoapellido;
            this.lo = lo;
            this.sexo = sexo;
            this.edad = edad;
        }

        public String nombre { get; set; }
        public String primerapellido { get; set; }
        public String segundoapellido { get; set; }
        public String lo { get; set; }
        public String sexo { get; set; }

        public int edad { get; set; }

        override public string ToString()
        {
            return nombre + "    " + edad.ToString() + "     " + sexo + "     " + lo;
        }



    }
}
