using System;
using System.Diagnostics.Eventing.Reader;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de métodos en C#");

            Saludar();
            IngresoNumero();
        }

        // Metodo ejemplo 1
        static void Saludar()
        {
            Console.WriteLine("Saludos desde el método Saludar");
        }


        // Método ejemplo 2: IngresoNumero
        static void IngresoNumero()
        {
            int numero;
            Console.Write("Ingresa tu número: ");
            string input = Console.ReadLine();


            if (int.TryParse(input, out numero))
            {
                Console.WriteLine("\nTabla de Sumar o Multiplicar");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Multiplicar");
                Console.Write("Elige una opción: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Sumar(numero);
                            break;
                        case 2:
                            Multiplicar(numero);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
        }


        // Metodo de la tabla de Sumar
        static void Sumar(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num + " + " + i + " = " + (num + i));
            }
        }

        // Metodo de la tabla de Multiplicar
        static void Multiplicar(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}
