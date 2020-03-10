using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAlumnos
{
    class Alumno
    {
        public Alumno(string nombre, string primerapellido, string segundoapellido, string ci, string sexo, int edad)
        {
            this.nombre = nombre;
            this.primerapellido = primerapellido;
            this.segundoapellido = segundoapellido;
            this.ci = ci;
            this.sexo = sexo;
            this.edad = edad;
        }

        public String nombre { get; set; }
        public String primerapellido { get; set; }
        public String segundoapellido { get; set; }
        public String ci { get; set; }
        public String sexo { get; set; }

        public int edad { get; set; }

    }
}
