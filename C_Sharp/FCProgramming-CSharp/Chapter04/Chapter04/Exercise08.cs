using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise08
    {
        public void Execute()
        {
            Console.WriteLine("Ingresa 5 numeros separados por un espacio: ");
            string input = Console.ReadLine();
            string[] inputPars = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputPars.Length != 5)
            {
                Console.WriteLine("Debes ingresar 5 numeros");
                return;
            }

            List<int> list = new List<int>();

            for (int i = 0; i < inputPars.Length; i++)
            {
                int.TryParse(inputPars[i], out int number);
                list.Add(number);
            }
            
            int greatest = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > greatest)
                {
                    greatest = list[i];
                }
            }

            Console.WriteLine("El numero mayor es: {0}", greatest);
        }
}
}
