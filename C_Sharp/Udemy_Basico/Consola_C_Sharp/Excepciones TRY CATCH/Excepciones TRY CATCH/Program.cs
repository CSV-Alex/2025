using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_TRY_CATCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.WriteLine("Introduce tu edad: ");
                Edad = int.Parse(Console.ReadLine());
                if (Edad < 18)
                {
                    Console.WriteLine("Eres menor de edad");
                }
                else
                {
                    Console.WriteLine("Eres mayor de edad");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
