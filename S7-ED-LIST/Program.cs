using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_ED_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a List of integers
            // Here we are not setting
            // Capacity explicitly
            List<int> firstlist = new List<int>();

            // adding elements in firstlist
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Adding some more
            // elements in firstlist
            firstlist.Add(5);
            firstlist.Add(6);

            // Printing the Capacity of firstlist
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            Console.WriteLine("Presione ENTER para CONTINUAR");
            Console.ReadLine();

            // Adding elements to List
            firstlist.Add(17);
            firstlist.Add(19);
            firstlist.Add(21);
            firstlist.Add(9);
            firstlist.Add(75);
            firstlist.Add(19);
            firstlist.Add(73);

            Console.WriteLine("Elements Present in List:\n");

            int p = 0;

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine(" ");

            // removing the element at index 3
            Console.WriteLine("Removing the element at index 3\n");

            // 9 will remove from the List
            // and 75 will come at index 3
            firstlist.RemoveAt(3);

            int p1 = 0;

            // Displaying the elements of List
            foreach (int n in firstlist)
            {
                Console.Write("At Position {0}: ", p1);
                Console.WriteLine(n);
                p1++;
            }

            Console.WriteLine("Presione ENTER para CONTINUAR");
            Console.ReadLine();
        }
    }
}
