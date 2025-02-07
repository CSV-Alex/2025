using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise01
    {
        // Declare several variables by selecting for each one of them the most appropiate of the types
        // sbyte, byte, short, ushort, int, uint, long and ulong.

        public void Exercise01_01()
        {
            // sbyte: Signed 8-bit integer (-128 to 127)
            sbyte a = -115;
            sbyte b = -112;
            sbyte c = -44;

            // byte; Unsigned 8-bit integer (0 to 255)
            byte d = 97;
            byte e = 224;

            // short: Signed 16-bit integer (-32,768 to 32,767)
            short f = -10000;
            short g = 1990;

            // ushort: Unsigned 16-bit integer (0 to 65,535)
            ushort h = 20000;

            // int: Signed 32-bit integer (-2,147,483,648 to 2,147,483,647)
            int i = 52130;
            int j = 4825932;

            //uint : Unsigned 32-bit integer (0 to 4,294,967,295)
            uint k = 970700000;

            // long: Signed 64-bit integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
            long l = -1000000000000000000;

            // ulong: Unsigned 64-bit integer (0 to 18,446,744,073,709,551,615)
            ulong m = 123456789123456789;
        }
    }
}
