using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4Struct
{
    internal class Program
    {
        struct Coordenada
        {
            public int x;
            public int y;

            //
            //public int x = -1;
            //public int y = -1;

            //
            //public Coordenada()
            //{
            //    this.x = -1;
            //    this.y = -1;
            //}


            public Coordenada(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Coordenada GetOrigin()
            {
                return new Coordenada();
                //return new Coordenada(-1, -1);
            }
        }

        static void Main(string[] args)
        {

            Coordenada point = new Coordenada(10, 20);

            Console.WriteLine("X:" + point.x); //output: 10  
            Console.WriteLine("Y:" + point.y); //output: 20

            point.x = 20;
            point.y = 30;

            point = Coordenada.GetOrigin();            

            Console.WriteLine("X:" + point.x); //output: 0  
            Console.WriteLine("Y:" + point.y); //output: 0  

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }
    }
}
