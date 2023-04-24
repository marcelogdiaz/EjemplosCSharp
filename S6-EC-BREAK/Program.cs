using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_BREAK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Here, the break statement
            // terminates the loop when x = 7
            //for (int a = 0; a <= 20; a+=2)
            //{
            //    if (a == 7)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(a);
            //}

            ////EJEMPLO ANIDADO
            //// Outer Loop
            //for (int i = 0; i < 4; i++)
            //{
            //    // Inner Loop
            //    for (int y = 1; y < 4; y++)
            //    {
            //        if (y > 2)
            //        {
            //            break;
            //        }
            //        Console.Write("#");
            //    }
            //    Console.Write("\n");
            //}

            //EJEMPLO CONTINUE
            // Here, in this for loop start from 2 to 12, 
            // due to the continue statement, when x = 8
            // it skip the further execution of the statements
            // and transfer the controls back to the 
            // next iteration of the for loop
            for (int j = 2; j <= 12; j++)
            {
                if (j == 8)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

            ////EJEMPLO CONTINUE DOS
            //int x = 0;

            //// Here, using continue statement
            //// whenever the value of x<2, it
            //// skips the further execution of the
            //// statements and the control transfer
            //// to the next iteration of while loop
            //while (x < 8)
            //{
            //    x++;

            //    if (x < 2)
            //        continue;

            //    Console.WriteLine(x);
            //}

            Console.ReadLine();
        }
    }
}
