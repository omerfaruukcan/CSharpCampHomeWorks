using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Value Data Types

            // Signed & Unsigned Integral Types

            sbyte signedInteger = 15; // -128 to 127 (8 bit)
            short signedInteger2 = 25125; // -32768 to 32767 (16 bit)
            int signedInteger3 = 124124124; // (32 bit)
            long signedInteger4 = 1245125125125; // (64 bit)
            byte unsignedInteger = 232; // 0 to 255 (8 bit)
            ushort unsignedInteger2 = 65454; // 0 to 65535 (16 bit)
            uint unsignedInteger3 = 454545665; // 0 to 2^32 (32 bit)
            ulong unsignedInteger4 = 54646545646546; // 0 to 2^63 (64 bit)

            // Floating Point Types

            float number1 = 10.3235F; // 32 bit - 7 digit Precision
            double number2 = 124.15231D; // 64 bit - 14/15 digit Precision

            // Decimal Types

            decimal number3 = 154948.124151251M; // 128 bit - 28/29 digit Precision

            // Character Types

            char a = 'G'; // 16 bit

            // Boolean Types

            bool b1 = true;
            bool b2 = false;

            // 2 - Reference Data Types

            // String

            string s1 = "hello"; // creating through string keyword
            String s2 = "welcome"; // creating through String class

            //Object

            object obj;
            obj = 20;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());

            // 3 - Pointer Data Types

            // ampersand (&): It is Known as Address Operator. It is used to determine the address of a variable.
            // asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.
        }
    }
}
