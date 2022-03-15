using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("GeeksforGeeks");

                // Increment the value of x for
                // next iteration
                x++;
            }
        }
    }
}