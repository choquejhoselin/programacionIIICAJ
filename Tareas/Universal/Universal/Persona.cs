using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    abstract class Persona
    {
        protected String nombres;
        protected String apellidos;
        protected Sexo sexo;
        protected String fechanacimiento;
        protected int celular;
        protected String correo;

        public void setDatos(string nombres, string apellidos, Sexo sexo, string fechanacimiento, int celular, string correo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.fechanacimiento = fechanacimiento;
            this.celular = celular;
            this.correo = correo;
        }

        public int getEdad()
        {
            return 0;
        }
        abstract public String GetDatos();
    }
    enum Sexo
    {
        Masculino,
        Femenino
    }
}
