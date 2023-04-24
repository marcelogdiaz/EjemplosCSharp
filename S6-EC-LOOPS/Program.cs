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

            //// Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine($"{x} WHILE");

                // Increment the value of x for
                // next iteration
                x++;
            }


            //DO WHILE
            //x = 18;
            //do
            //{
            //    // The line will be printed even
            //    // if the condition is false
            //    Console.WriteLine($"DO WHILE {x}");
            //    x++;
            //}
            //while (x < 20);

            //int maxTabla = 10;

            //////NESTED FOR
            //// loop within loop printing GeeksforGeeks
            //for (int i = 0; i <= maxTabla; i++)
            //{
            //    for (int j = 0; j <= maxTabla; j++)
            //    {
            //        Console.WriteLine($"{i} {j} LOOP");
            //    }                
            //}

            Console.ReadLine();
        }
    }
}
