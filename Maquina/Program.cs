using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Maquina
{
    public class Program
    {
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public int VecesCompradas { get; set; }
        public int Total { get; set; }
        public int Ingreso { get; set; }
        public int Cambio { get; set; }
        public List<object> Resumen { get; set; } 
        static void Main(string[] args)
        {
            Program lis = new Program();
            string producto;
            string nombre;
            int costoProducto = 0;
            int ingresado;
            int monedasIngresada = 0;
            int confirmacionCompra;
            int cambio;
            int contadorCambio = 0;
            int vecesCompradas = 0;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            lis.Resumen = new List<object>();
            do
            {
                vecesCompradas ++;
                //Solicita Producto 
                Console.WriteLine("Productos");
                Console.WriteLine("Producto: A costo de $270");
                Console.WriteLine("Producto: B costo de $340");
                Console.WriteLine("Producto: C costo de $390");
                Console.WriteLine("Ingresa la letra del Producto");
                producto = Console.ReadLine();
                //Asigna el valor del producto
                if(producto == "A")
                {
                    costoProducto = 270;
                }
                else if(producto == "B")
                {
                    costoProducto = 340;
                }else if(producto == "C")
                {
                    costoProducto = 390;
                }
                int costo =costoProducto;
                ingresado = 0;
                do
                {
                    
                    Console.WriteLine("Ingresa el dinero la cantidad de: " + costo);
                    Console.WriteLine("Solo admite mondedas de Monto: $10,$50 y $100");
                    int monedas = int.Parse(Console.ReadLine());
                    if( monedas == 50 || monedas == 10 || monedas == 100)
                    {
                        costo -= monedas;
                        ingresado += monedas;
                        monedasIngresada++;
                        
                    }
                    else
                    {
                        Console.WriteLine("Ingresa las cantidades solicitadas");
                    }
                } while (costoProducto > ingresado);
                if( ingresado >= costoProducto)
                {
                    cambio = ingresado - costoProducto;
                    Console.WriteLine("Cambio: " + cambio);
                    do
                    {
                        if (cambio >= 100)
                        {
                            cambio -= 100;
                            contadorCambio++;
                            Console.WriteLine("100");
                        }
                        else if (cambio >= 50)
                        {
                            cambio -= 50;
                            contadorCambio++;
                            Console.WriteLine("50");
                        }
                        else if (cambio >= 10)
                        {
                            cambio -= 10;
                            contadorCambio++;
                            Console.WriteLine("10");
                        }                        

                    } while (1 < cambio);
                    Console.WriteLine("Gracias Por su compra");
                }
                else
                {
                    Console.WriteLine("Gracias Por su compra");

                }
                lis.Nombre = nombre;
                lis.Producto = producto;
                lis.VecesCompradas = vecesCompradas;
                lis.Total = costoProducto;
                lis.Ingreso = monedasIngresada;
                lis.Cambio = contadorCambio;

                lis.Resumen.Add(lis);

                Console.WriteLine("Desea volver a comprar: Igrese 1 si desea volver a comprar y 0 si no desea volver a comprar");
                confirmacionCompra = int.Parse(Console.ReadLine());
                
            } while (confirmacionCompra > 0);

            Console.WriteLine("FIN");
            Console.ReadLine();
        }

         
    }
}