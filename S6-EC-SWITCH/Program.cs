using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_EC_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EJEMPLO SIMPLE
            string subject = "C#";

            // passing string "subject" in
            // switch statement
            switch (subject)
            {

                case "Java":
                    Console.WriteLine("Subject is Java");
                    break;

                case "C++":
                    Console.WriteLine("Subject is C++");
                    break;

                default:
                    Console.WriteLine("Subject is C#");
                    break;

            }

            //EJEMPLO DOS

            //// taking two strings value
            //string topic;
            //string category;

            //// taking topic name
            //topic = "Inheritance";

            //// using switch Statement
            //switch (topic)
            //{
            //    case "Introduction to C#":
            //    case "Variables":
            //    case "Data Types":

            //        category = "Basic";
            //        break;

            //    case "Loops":
            //    case "If Statements":
            //    case "Jump Statements":

            //        category = "Control Flow";
            //        break;

            //    case "Class & Object":
            //    case "Inheritance":
            //    case "Constructors":

            //        category = "OOPS Concept";
            //        break;

            //    // default case 
            //    default:
            //        category = "Not Mentioned";
            //        break;

            //}

            //System.Console.Write("Category is " + category);

            Console.ReadLine();
        }
    }
}
