using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("WHILE");

                // Increment the value of x for
                // next iteration
                x++;
            }


            ////DO WHILE
            //x = 21;
            //do
            //{
            //    // The line will be printed even
            //    // if the condition is false
            //    Console.WriteLine("DO WHILE");
            //    x++;
            //}
            //while (x < 20);

            ////NESTED FOR
            //// loop within loop printing GeeksforGeeks
            //for (int i = 2; i < 3; i++)
            //    for (int j = 1; j < i; j++)
            //        Console.WriteLine($"{i} {j} LOOP");

            Console.ReadLine();
        }
    }
}
