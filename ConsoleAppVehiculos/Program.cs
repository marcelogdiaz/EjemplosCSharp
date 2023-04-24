using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Importamos ConsoleAppVehiculos.Entidades para poder utilizar las Clases que se encuentran en la carpeta Entidades
 */
using ConsoleAppVehiculos.Entidades;


/// <summary>
/// Aca comienza el codigo del Program.cs
/// </summary>
namespace ConsoleAppVehiculos
{
    public class Program
    {
        enum Autos
        { Ford, Chevrolet,Fiat, Renault }

        //public static void Main()
        public static void Main(string[] args)
        {
            //Muestra la cantidad de parametros (separados por espacio) que se llaman en....
            //<DIRECTORIO>\ConsoleAppVehiculos.exe parametro1 parametro2 parametro3
            Console.WriteLine("Cantidad de parametros ARGS {0}", args.Count());

            List<Autos> miFlotaAutos = new List<Autos>();

            //miFlotaAutos.Add(Autos.Renault);
            //miFlotaAutos.Add(Autos.Renault);
            //miFlotaAutos.Add(Autos.Ford);
            //miFlotaAutos.Add(Autos.Fiat);

            int contador = 1;
            foreach (var item in miFlotaAutos)
            {
                //Console.WriteLine("AUTO {0}: {1}",contador, item);
                Console.WriteLine($"AUTO {contador}: {item}");
                contador++;
            }


            ////Muestra la cantidad de parametros (separados por espacio) que se llaman en....
            ////<DIRECTORIO>\ConsoleAppVehiculos.exe parametro1 parametro2 parametro3
            //Console.WriteLine("Cantidad de parametros ARGS {0}", args.Count());

            ////Declaramos nuestra FLOTA como un diccionario
            //Dictionary<Autos, int> flota = new Dictionary<Autos, int>();

            ////inicializamos la flota de autos en 0
            //flota[Autos.Ford] = 0;
            //flota[Autos.Chevrolet] = 0;
            //flota[Autos.Fiat] = 0;
            //flota[Autos.Renault] = 0;

            //string x;
            //bool salir = false;
            //while (!salir) {
            //    Console.WriteLine("Ingrese 0-Ford, 1-Chevrolet, 2-Fiat, 3-Renault, 4-SALIR seguido de ENTER");
            //    x = Console.ReadLine();
            //    switch (x)
            //    {
            //        case "0":
            //            flota[Autos.Ford]++;
            //            break;
            //        case "1":
            //            flota[Autos.Chevrolet]++;
            //            break;
            //        case "2":
            //            flota[Autos.Fiat] ++;
            //            break;
            //        case "3":
            //             flota[Autos.Renault]++;
            //            break;
            //        case "4":
            //            salir = true;
            //            break;
            //    }
            //}

            ////Mostramos la cantidad ingresada de cada vehiculo
            //Console.WriteLine($"Hay {flota[Autos.Ford]} vehiculos {Autos.Ford}" );
            //Console.WriteLine($"Hay {flota[Autos.Chevrolet]} vehiculos {Autos.Chevrolet}");
            //Console.WriteLine($"Hay {flota[Autos.Fiat]} vehiculos {Autos.Fiat}");
            //Console.WriteLine($"Hay {flota[Autos.Renault]} vehiculos {Autos.Renault}");


            //Console.WriteLine((int)Autos.Ford);   //permite acceder al INDICE del ENUMERADO

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            ////Declaramos una varible de tipo Vehiculo
            //Vehiculo miVehiculo;

            //miVehiculo  = new Vehiculo("Audi",4);     

            ///*
            // * Creamos un objeto de Clase Moto, si bien miVehiculo es de una clase Padre, por POLIMORFISMO es posible crear instancia de la clase Derivada
            // */
            ////miVehiculo = new Moto("Ducati", 2); 
            //miVehiculo.alinear();
            //miVehiculo.cambiarRueda();
            //miVehiculo.medirPresion();
        }

    }
}
