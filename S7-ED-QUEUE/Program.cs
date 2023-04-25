using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue
            // Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("UPSO");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("C#-NET");

            // Accessing the elements
            // of my_queue Queue
            // Using foreach loop
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Presione ENTER para CONTINUAR");
            Console.ReadLine();

            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);
            my_queue.Dequeue();

            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);

            // Remove all the elements from the queue
            my_queue.Clear();

            // After Clear method
            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);

            Console.WriteLine("Presione ENTER para CONTINUAR");
            Console.ReadLine();

            my_queue.Enqueue("UPSO");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("C#-NET");

            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Dequeue method
            Console.WriteLine("Topmost element of my_queue is: {0}", my_queue.Dequeue());

            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Peek method
            Console.WriteLine("Topmost element of my_queue is: {0}",my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);

            Console.WriteLine("Presione ENTER para CONTINUAR");
            Console.ReadLine();
        }
    }
}
