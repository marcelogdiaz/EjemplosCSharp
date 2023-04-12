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
            ////-----CONSTANTES
            //const string Language = "C#";
            //const string Platform = ".NET";
            //const string Version = "10.0";
            //const string FullProductName = Platform+" - "+Language+": "+Language+" Version: "+Version;

            ////string FullProductName = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            ////Version = "2";        //error porque esta declarado como CONSTANTE

            //Console.WriteLine(FullProductName);

            //Console.WriteLine($"int.MinValue = {int.MinValue}");
            //Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            //Console.WriteLine($"float.MinValue = {float.MinValue}");
            //Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            //Console.WriteLine($"double.MinValue = {double.MinValue}");
            //Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            //Console.WriteLine($"decimal.MinValue = {decimal.MinValue}");
            //Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            //Console.WriteLine($"short.MinValue = {short.MinValue}");
            //Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            //Console.WriteLine($"long.MinValue = {long.MinValue}");
            //Console.WriteLine($"long.MaxValue = {long.MaxValue}");

            //double numdouble = 3.78;

            //decimal division(decimal d1, decimal d2) {
            //    decimal resul = 0;
            //    resul = d1 / d2;
            //    return resul;
            //}

            //decimal numdecimal = 3.78M;
            //int entero;

            //entero = (int)numdouble;

            //entero = (int)numdecimal;

            //int resultado;
            //resultado = (int)division(8, 3);

            int i = 3;
            int j = i++;

            int k = ++i;

            int l = 5;
            //l += 9;
            
            l =+ 9;

            Console.ReadLine();

        }
    }
}
