using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace servidoraritmetica
{
    class Program
    {
        // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
            // Bufer de Datos paralosdatos recibidos  
            byte[] bytes = new Byte[1024];

            // Establece el punto deentrada final para el socket.  
            // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            // Crea un Socket TCP/IP x.  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  
             
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                       

                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto recibido: {0}", data);
                    string[] mensajedescompuesto = data.Split(',');
                    string operacion = mensajedescompuesto[0];
                    double a = double.Parse(mensajedescompuesto[1]);
                    double b= double.Parse(mensajedescompuesto[2]);
                    double c = 0;
                    switch(operacion)
                    {
                        case "sumar":
                            c = Aritmetica.getInstancia().suma(a, b);
                            break;
                        case "restar":
                            c = Aritmetica.getInstancia().resta(a, b);
                            break;
                        case "multiplicar":
                            c = Aritmetica.getInstancia().producto(a, b);
                            break;
                        case "dividir":
                            c = Aritmetica.getInstancia().division(a, b);
                            break;
                        case "potencia":
                            c = Aritmetica.getInstancia().potencia(a, b);
                            break;
                        case "raiz":
                            c = Aritmetica.getInstancia().raiz(a, b);
                            break;
                        default:
                            c = -1;
                            break;
                    }
                    // Prepara los datos para responder  al cliente.  
                    byte[] msg = Encoding.ASCII.GetBytes(c.ToString());

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {

            StartListening();
            return 0;
        }
    }
}
