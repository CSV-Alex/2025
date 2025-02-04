using System;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de métodos en C#");

            Saludar();
            IngresoDatos();
        }

        // Metodo ejemplo 1
        static void Saludar()
        {
            Console.WriteLine("Saludos desde el método Saludar");
        }

        // Metodo ejemplo 2
        static void IngresoDatos()
        {
            string Nombre;
            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre);
        }
    }
}
