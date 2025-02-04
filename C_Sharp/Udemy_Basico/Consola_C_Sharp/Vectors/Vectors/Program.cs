using System;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "AXEL", "CARLOS", "LUIS", "JORGE" };
            Console.WriteLine("Nombres de los alumnos: ");
            foreach (string Nombre in Nombres)
            {
                Console.WriteLine(Nombre);
            }           
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine(Nombres[i]);
            }

            Console.ReadKey();
        }
    }
}
