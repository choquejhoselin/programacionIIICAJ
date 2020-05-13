using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabajo1;

namespace Fabricadeanimales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            FabricaMamiferos f = new FabricaMamiferos();
            Zoologico z = new Zoologico("SantaCruz","3eranillo",72855884);
            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar mamifero");
              
                Console.WriteLine("2. Mostrar jaula");
                Console.WriteLine("3. Ingresar ave");
                Console.WriteLine("4. Mostrar Aviario");
                Console.WriteLine("5. Ingresar pez");
                Console.WriteLine("6. Mostrar Acuario");
                Console.WriteLine("7. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Que mamifero vaingresar (mono/oso/leon)? ");
                        string animal=Console.ReadLine();
                        Console.WriteLine("Nombre? ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Temperatura? ");
                        double temperatura = Double.Parse(Console.ReadLine());
                        Console.WriteLine("nro patas ");
                        double ndepat = Double.Parse(Console.ReadLine());

                        Mamiferos uno= f.getMamifero(animal,nombre,temperatura,ndepat);
                        z.anadirMamifero(uno,10,5,3);
                        Console.ReadKey();
                        break;
                    case 2:
                        z.imprimir();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Que Ave va ingresar (Condor/Aguila/Loro)? ");
                        string ave = Console.ReadLine();
                        Console.WriteLine("Nombre? ");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Peso? ");
                        double peso = Double.Parse(Console.ReadLine());
                        Console.WriteLine("tamaño alas ");
                        double tamañoalas = Double.Parse(Console.ReadLine());

                        Aves dos = f.getAves(ave,nom,peso,tamañoalas);
                        z.anadirAves(dos, 10, 5, 3);
                        Console.ReadKey();
                        break;
                    case 4:
                        z.imprimir();
                        Console.ReadKey();
                        
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Que Ave va ingresar (Condor/Aguila/Loro)? ");
                        string pez = Console.ReadLine();
                        Console.WriteLine("Nombre? ");
                        string nomb = Console.ReadLine();
                        Console.WriteLine("Peso? ");
                        double longitud = Double.Parse(Console.ReadLine());
                        

                        Pezes tres = f.getPezes(pez, nomb, longitud);
                        z.anadirAcuario(tres, 10, 5, 3);
                        Console.ReadKey();
                        break;
                    case 6:
                        z.imprimir();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
