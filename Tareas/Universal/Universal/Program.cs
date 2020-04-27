using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal
{
    class Program
    {
       
            static void Main(string[] args)
            {
                

                FabricaPersona fabricapersonas = new FabricaPersona();
              
                Persona Daniel = fabricapersonas.getPersona("alumno");
                

                Daniel.setDatos("Jhoselin", "Choque", Sexo.Femenino, "14/01/2001*", 78692781, "choquejhoselin84@");
                Console.WriteLine(Daniel.GetDatos());
                FabricaAula fabricaaulas = new FabricaAula();

                Aula a = fabricaaulas.getAula("teoria", null);
                a.setDatos("A202", new Ubicacion(1, 2), new Tamaño(3, 4), 30);
                List<Computadora> ab = new List<Computadora>();
                List<DiscoDuro> l = new List<DiscoDuro>();
                l.Add(new DiscoDuro("hitachi", 2, MedidaCapacidad.Tb));
                Computadora c = new Computadora(Marca.Lenovo, "tinkpad", new Procesador("Intel", 24), l, Color.negro, 2018);
                for (int i = 1; i <= 18; i++)
                {
                    ab.Add((Computadora)c.Clone());
                }
                Aula l302 = fabricaaulas.getAula("laboratorio", ab);
                l302.setDatos("L302", new Ubicacion(1, 4), new Tamaño(3, 5), 25);
                Console.WriteLine(a.getDatos());
                

                Console.WriteLine(a);
               
             

                Console.ReadKey();

            }
        
    }
}
