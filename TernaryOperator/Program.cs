using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string result = a > b ? "a is greater than b" : a < b ? "b is greater than a" : "a is equal to b";

            Console.WriteLine(result);

            int number = 2;
            bool isEven;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

        }
    }
}