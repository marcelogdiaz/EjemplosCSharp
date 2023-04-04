using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IGUALDAD
            string a = "hello";
            string b = "h";
            // Append to contents of 'b'
            b += "ello";
            Console.WriteLine(a == b);
            Console.WriteLine(object.ReferenceEquals(a, b));

            //CREACION DE STRING
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "UPSO", "C#" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            //INMUTABILIDAD---------
            string str1 = "Hello ";
            string str2 = str1;
            str1 += "World";

            Console.WriteLine(str2);
            //Output: Hello


            //LITERALES-------------------
            string columns = "Column 1\tColumn 2\tColumn 3";
            Console.WriteLine(columns);

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);

            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(title);

            string filePath = @"C:\Users\scoleridge\Documents\";
            Console.WriteLine(filePath);

            string text = @"My pensive SARA ! thy soft cheek reclined
                        Thus on mine arm, most soothing sweet it is
                        To sit beside our Cot,...";
            Console.WriteLine(text);

            string quote = @"Her name was ""Sara.""";
            Console.WriteLine(quote);


            //------INTERPOLACION
            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

            // Output:
            // Jupiter Hammon was an African American poet born in 1711.
            // He was first published in 1761 at the age of 50.
            // He'd be over 300 years old today.

            //SUBCADENAS
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));
            // Output: "C#"

            System.Console.WriteLine(s3.Replace("C#", "Basic"));
            // Output: "Visual Basic Express"

            // Index values are zero-based
            int index = s3.IndexOf("C");
            // index = 7

            Console.ReadLine();
        }
    }
}
