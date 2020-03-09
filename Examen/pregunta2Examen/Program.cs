using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta2Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            datos[] listadatos = new datos[4];
            Insertartodos(listadatos);
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("1.- lista de mesas ordenadas ");
                Console.WriteLine("2.- lista de mesas donde la votacion el CC es mayor a 20 ordenadas por su ciudad");
                Console.WriteLine("3.- Cantidad de votos por agrupados por eleccion");
                Console.WriteLine("4.- Cantidad de votos para presidente agrupados por eleccion");
                Console.WriteLine("5.- Mesas donde gano CC GANO");

                Console.WriteLine("6.- Salir");
                Console.Write("Introduzca opcion ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        lista (listadatos);
                        break;
                    case 2:
                        listaCCmayor(listadatos);
                        break;
                    case 3:
                     cantidadV(listadatos);
                        break;
                    case 4:
                       votospresidente(listadatos);
                        break;

                    case 4:
                       mesasganoCC(listadatos);
                        break;
                    default:
                        break;
                }
            }

           
        }
    }
}
