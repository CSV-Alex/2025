using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];
            Persona[0, 0] = "AXEL";

            Console.WriteLine("Nombre: " + Persona[0, 0]);

            string[,] Persona2 = { { "AXEL", "GARCIA" } };

            for (int i = 0; i < Persona2.GetLength(0); i++)
            {
                for (int j = 0; j < Persona2.GetLength(1); j++)
                {
                    Console.WriteLine(Persona2[i, j]);
                }
            }
        }
    }
}
