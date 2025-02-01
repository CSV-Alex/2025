using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int num1, num2;
            bool Operaciones;
            num1 = 10;
            num2 = 20;
            Operaciones = (num1 >= num2);
            Console.WriteLine("num1 es mayor que num2? " + Operaciones);
            */

            int a, b, c, d;
            bool Resultado;
            a = 10;
            b = 2;
            c = 0;
            d = 205;
            Resultado = ((a > b) && (c <= d) && (a > c)) || (a == b);
            Console.WriteLine("(a > b) && (c <= d) && (a > c) || (a == b) es " + Resultado);
        }
    }
}
