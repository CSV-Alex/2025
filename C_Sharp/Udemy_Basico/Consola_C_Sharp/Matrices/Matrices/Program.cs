using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];
            Persona[0, 0] = "AXEL";

            Console.WriteLine("Nombre: " + Persona[0, 0]);
        }
    }
}
