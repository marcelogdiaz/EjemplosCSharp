using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_ECIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO SIMPLE

            // Declaring and initializing variables
            string x = "UPSO C#";
            string y = "UPSO C#";

            // If statement
            if (x == y)
            {
                Console.WriteLine("Ambos strings son iguales..!!");
            }

            // If statement
            if (x != y)
            {
                Console.WriteLine("Ambos strings NO son iguales..!!");
            }

            //EJEMPLO ANIDADO
            //// taking two strings value
            //string topic;
            //string category;

            //// taking topic name
            //topic = "Loops";
            ////topic = "Inheritance";

            //// using compare function of string class
            //if ((String.Compare(topic, "Introduction to C#") == 0) ||
            //    (String.Compare(topic, "Variables") == 0) ||
            //    (String.Compare(topic, "Data Types") == 0))
            //{
            //    category = "Basic";
            //}

            //// using compare function of string class
            //else if ((String.Compare(topic, "Loops") == 0) ||
            //         (String.Compare(topic, "If Statements") == 0) ||
            //         (String.Compare(topic, "Jump Statements") == 0))
            //{
            //    category = "Control Flow";
            //}

            //// using compare function of string class
            //else if ((String.Compare(topic, "Class & Object") == 0) ||
            //         (String.Compare(topic, "Inheritance") == 0) ||
            //         (String.Compare(topic, "Constructors") == 0))
            //{
            //    category = "OOPS Concept";
            //}

            //else
            //{
            //    category = "Not Mentioned";
            //}

            //System.Console.Write("Category is " + category);

            Console.ReadLine();
        }
    }
}
