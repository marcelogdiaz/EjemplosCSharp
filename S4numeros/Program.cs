using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace S4numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //-----CONSTANTES
            const string Language = "C#";
            const string Platform = ".NET";
            const string Version = "10.0";
            const string FullProductName = Platform+" - "+Language+": "+Language+" Version: "+Version;

            //const string FullProductName = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Console.WriteLine(FullProductName);





            Console.WriteLine($"int.MinValue = {int.MinValue}");
            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"float.MinValue = {float.MinValue}");
            Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            Console.WriteLine($"double.MinValue = {double.MinValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            Console.WriteLine($"decimal.MinValue = {decimal.MinValue}");
            Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            Console.WriteLine($"short.MinValue = {short.MinValue}");
            Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            Console.WriteLine($"long.MinValue = {long.MinValue}");
            Console.WriteLine($"long.MaxValue = {long.MaxValue}");


            Console.ReadLine();

        }
    }
}
