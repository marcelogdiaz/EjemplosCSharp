using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4Struct
{
    internal class Program
    {
        struct Coordinate
        {
            public int x;
            public int y;

            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Coordinate GetOrigin()
            {
                return new Coordinate();
            }
        }

        static void Main(string[] args)
        {

            Coordinate point = new Coordinate(10, 20);

            Console.WriteLine("X:" + point.x); //output: 10  
            Console.WriteLine("Y:" + point.y); //output: 20


            point = Coordinate.GetOrigin();            

            Console.WriteLine("X:" + point.x); //output: 0  
            Console.WriteLine("Y:" + point.y); //output: 0  

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }
    }
}
