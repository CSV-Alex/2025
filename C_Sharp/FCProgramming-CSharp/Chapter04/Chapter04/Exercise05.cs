using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise05
    {
        public void Execute()
        {
            Console.Write("Enter two numbers separated by a space: ");
            string input = Console.ReadLine();
            
            string[] inputPars = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int [inputPars.Length];
            List<int> list = new List<int>();

            for(int i = 0; i < inputPars.Length; i++)
            {
                int.TryParse(inputPars[i], out numbers[i]);
            }

            int start = numbers[0];
            int end = numbers[1];
            int fiveBucle = 0;

            while (fiveBucle < end)
            {
                if (fiveBucle <= start)
                {
                    fiveBucle += 5;
                }

                if (fiveBucle > start && fiveBucle < end)
                {
                    list.Add(fiveBucle);
                    fiveBucle += 5;
                }
            }

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

        }
    }
}
