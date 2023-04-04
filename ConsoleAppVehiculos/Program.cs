using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Importamos ConsoleAppVehiculos.Entidades para poder utilizar las Clases que se encuentran en la carpeta Entidades
 */
using ConsoleAppVehiculos.Entidades;

namespace ConsoleAppVehiculos
{
    internal class Program
    {

        enum Autos
        { Ford, Chevrolet, Fiat, Renault }

        public static void Main(string[] args)
        {

            Dictionary<Autos, int> flota = new Dictionary<Autos, int>();

            flota[Autos.Ford] = 0;
            flota[Autos.Chevrolet] = 0;
            flota[Autos.Fiat] = 0;
            flota[Autos.Renault] = 0;

            //Declaramos una varible de tipo Vehiculo
            Vehiculo miVehiculo;
            
            miVehiculo  = new Vehiculo("Audi",4);     

            /*
             * Creamos un objeto de Clase Moto, si bien miVehiculo es de una clase Padre, por POLIMORFISMO es posible crear instancia de la clase Derivada
             */
            //miVehiculo = new Moto("Ducati", 2); 
            miVehiculo.alinear();
            miVehiculo.cambiarRueda();
            miVehiculo.medirPresion();

            Console.WriteLine();


            /*
            int num;
            num = Convert.ToInt32(Console.ReadLine());  
             */

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }

    }
}
