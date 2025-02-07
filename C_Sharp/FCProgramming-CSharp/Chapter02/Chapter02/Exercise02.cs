using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise02
    {
        // Which of the following values can be assigned to variables of type float, double and decimal:
        // 5, -5.01, 34.567839023, 12.345, 8923.1234857, 3456.091124875956542151256683467
        public void Exercise02_02() 
        {
            // float: 
            // Can represent values with ~7 digits of precision
            float a = 5f;  
            float b = -5.01f;    
            float c = 12.345f;     

            // double:
            // Can represent values with ~15-16 digits of precision
            double d = 34.567839023;       
            double e = 8923.1234857;       

            // decimal:
            // Can represent values with ~28-29 digits of precision
            decimal f = -5.01m;            
            decimal g = 12.345m;           
            decimal h = 3456.091124875956542151256683467m; 

        }
    }
}
