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

            //// EJEMPLO SIMPLE
            //string subject = "C#";
            //// passing string "subject" in
            //// switch statement
            //switch (subject)
            //{
            //    case "Java":
            //        Console.WriteLine("Subject is Java");
            //        break;

            //    case "C++":
            //        Console.WriteLine("Subject is C++");
            //        break;

            //    default:
            //        Console.WriteLine("Subject is C#");
            //        break;
            //}

            //int valor = 0;
            //switch (valor)
            //{
            //    case 0:
            //        Console.WriteLine("El valor es CERO");
            //        break;
            //    default:
            //        if (valor > 0) {
            //            Console.WriteLine("El valor es MAYOR QUE CERO");
            //        }
            //        else {
            //            Console.WriteLine("El valor es MENOR QUE CERO");
            //        }
            //        break;
            //}

            //EJEMPLO DOS

            // taking two strings value
            string topic;
            string category;

            // taking topic name
            topic = "inheritance";

            // using switch statement
            switch (topic)
            {
                case "introduction to c#":
                case "variables":
                case "data types":

                    category = "basic";
                    break;

                case "loops":
                case "if statements":
                case "jump statements":

                    category = "control flow";
                    break;

                case "class & object":
                case "inheritance":
                case "constructors":

                    category = "oops concept";
                    break;

                // default case 
                default:
                    category = "not mentioned";
                    break;

            }

            Console.WriteLine("category is " + category);

            Console.ReadLine();
        }
    }
}
