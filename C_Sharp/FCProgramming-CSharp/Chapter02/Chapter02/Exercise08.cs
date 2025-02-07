using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise08
    {
        public void Execute()
        {
            string variable1 = "Hello";
            string variable2 = "World";
            object variable3 = variable1 + " " + variable2;
            string variable4 = (string)variable3; //type casting
            Console.WriteLine(variable4);
        }
    }
}
