using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_STACK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack
            // Using Stack class
            Stack my_stack = new Stack();

            //// Adding elements in the Stack
            //// Using Push method
            //my_stack.Push("Upso");
            //my_stack.Push("Programacion");
            //my_stack.Push("C#");
            //my_stack.Push(null);
            //my_stack.Push(1234);
            //my_stack.Push(490.98);

            //// Accessing the elements
            //// of my_stack Stack
            //// Using foreach loop
            //foreach (var elem in my_stack)
            //{
            //    Console.WriteLine(elem);
            //}
            
            //Console.WriteLine("Presione ENTER para CONTINUAR");
            //Console.ReadLine();

            //Console.WriteLine("Total elements present in" +
            //            " my_stack: {0}", my_stack.Count);

            //my_stack.Pop();

            //// After Pop method
            //Console.WriteLine("Total elements present in " +
            //              "my_stack: {0}", my_stack.Count);


            //// Remove all the elements
            //// from the stack
            //my_stack.Clear();

            //// After Pop method
            //Console.WriteLine("Total elements present in " +
            //              "my_stack: {0}", my_stack.Count);

            //Console.WriteLine("Presione ENTER para CONTINUAR");
            //Console.ReadLine();

            my_stack.Push("Upso");
            my_stack.Push("Programacion");
            my_stack.Push("C#");
            my_stack.Push(null);
            my_stack.Push(1234);
            my_stack.Push(490.98);

            Console.WriteLine("Total elements present in" +
                          " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Pop method
            Console.WriteLine("Topmost element of my_stack"
                              + " is: {0}", my_stack.Pop());

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Peek method
            Console.WriteLine("Topmost element of my_stack " +
                                  "is: {0}", my_stack.Peek());

            Console.WriteLine("Total elements present " +
                     "in my_stack: {0}", my_stack.Count);

        }
    }
}
