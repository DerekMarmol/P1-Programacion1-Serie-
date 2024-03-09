using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("Ingrese el precio de 3 productos diferentes, si el total es mayor a 500 se le descontará 10%");

            Console.WriteLine("Ingrese el precio del primer producto");
            double product1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del segundo producto");
            double product2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del tercer producto");
            double product3 = double.Parse(Console.ReadLine());

            double total = product1 + product2 + product3;
            if (total > 500 ) {
                double descuento = total * 0.10;
                Double descuentofinal = total - descuento;
                Console.WriteLine("Su total es mayor de 500, por lo tanto se le hará un descuento del 10%. Su total queda de: "+ descuentofinal);
            }
            else
            {
                Console.WriteLine("Su total es menor de 500, por lo tanto no se le aplicara descuento. Su total es de : " + total);
            }
            Console.Read();
        }
    }
}
