using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int nitem = 5;
            switch (nitem)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }
    }
}
