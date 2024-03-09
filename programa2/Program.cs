using System;

namespace GeneradorDeCorreoElectronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido! Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ahora, ingresa tu apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Por último, ingresa el dominio (por ejemplo, gmail.com):");
            string dominio = Console.ReadLine();

            string correoElectronico = GenerarCorreoElectronico(nombre, apellido, dominio);
            Console.WriteLine($"Tu dirección de correo electrónico es: {correoElectronico}");

            Console.Read();
        }

        static string GenerarCorreoElectronico(string nombre, string apellido, string dominio)
        {
            string nombreCorto = ObtenerTresPrimerasLetras(nombre);
            string apellidoCorto = ObtenerTresPrimerasLetras(apellido);

            string correo = $"{nombreCorto}{apellidoCorto}@{dominio}";

            return correo;
        }

        static string ObtenerTresPrimerasLetras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            return texto.Substring(0, Math.Min(texto.Length, 3)).ToLower();
        }


    }
}
