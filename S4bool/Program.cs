using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valorBooleano = true;

            bool otroValorBooleano = false;

            //if (valorBooleano ^  otroValorBooleano) {
            //    Console.WriteLine("THEN");
            //}
            //else {
            //    Console.WriteLine("ELSE");
            //}

            //if (valorBooleano)
            //{
            //    Console.WriteLine("Checked");
            //}
            //else
            //{
            //    Console.WriteLine("Not checked");
            //}

            //Console.WriteLine(valorBooleano ? "Checked" : "Not checked");  // output: Checked

            //Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked


            ////-----NOT
            //bool pasa = false;
            //Console.WriteLine(!pasa);  // output: True
            //Console.WriteLine(!true);    // output: False
            ////------------------------------------------------------------

            ////----AND
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // False

            bool b = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
            ////------------------------------------------------------------

            ////-----XOR
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
            ////------------------------------------------------------------


            ////-----OR
            a = true | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // True

            b = false | SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
            ////------------------------------------------------------------

            ////-----AND CONDICIONAL
            a = false && SecondOperand();
            Console.WriteLine(a);
            // Output:
            // False

            b = true && SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True
            ////------------------------------------------------------------

            ////----OR CONDICIONAL
            //a = true || SecondOperand();
            //Console.WriteLine(a);
            //// Output:
            //// True

            //b = false || SecondOperand();
            //Console.WriteLine(b);
            //// Output:
            //// Second operand is evaluated.
            //// True
            ////------------------------------------------------------------

            ////PRECEDENCIA OPERADORES
            Console.WriteLine(true | true & false);   // output: True
            Console.WriteLine((true | true) & false); // output: False

            //bool Operand(string name, bool value)
            //{
            //    Console.WriteLine($"Operand {name} is evaluated.");
            //    return value;
            //}

            //var byDefaultPrecedence = Operand("A", true) || Operand("B", true) && Operand("C", false);
            //Console.WriteLine(byDefaultPrecedence);
            //// Output:
            //// Operand A is evaluated.
            //// True

            //var changedOrder = (Operand("A", true) || Operand("B", true)) && Operand("C", false);
            //Console.WriteLine(changedOrder);
            //// Output:
            //// Operand A is evaluated.
            //// Operand C is evaluated.
            //// False
            ////------------------------------------------------------------

            ////---OPERADOR TERNARIO
            //string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

            //Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
            //Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!


            Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
            Console.ReadLine();

        }
    }
}
