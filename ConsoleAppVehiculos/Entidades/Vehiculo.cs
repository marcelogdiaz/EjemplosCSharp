using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Importamos ConsoleAppVehiculos.Interfaces para poder implementar IService y darle comportamiento a Vehiculo
 */
using ConsoleAppVehiculos.Interfaces;

namespace ConsoleAppVehiculos.Entidades
{
    public class Vehiculo : IService    //Aca indicamos que implementamos la Interfaz
    {
        public string marca;
        public int cantidadRuedas;

        /// <summary>
        /// Este es un constructor sin parametros
        /// </summary>
        public Vehiculo() { }

        /// <summary>
        /// Este es un constructor con parametros
        /// </summary>
        /// <param name="m"></param>
        /// <param name="cantRuedas"></param>
        public Vehiculo(string m, int cantRuedas)
        {
            this.marca = m;
            this.cantidadRuedas = cantRuedas;
        }

        /// <summary>
        /// Metodo que implementa la interface
        /// VIRTUAL significa que puede ser REDEFINIDA en una clase hija
        /// </summary>
        public virtual void alinear()
        {
            Console.WriteLine("Alineamos {0}", marca);
        }

        /// <summary>
        /// Metodo que implementa la interface
        /// VIRTUAL significa que puede ser REDEFINIDA en una clase hija
        /// </summary>
        public virtual void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} rueda {1}",cantidadRuedas, marca);
        }

        /// <summary>
        /// Metodo que implementa la interface
        /// Este metodo NO puede ser REDEFINIDO en una clase hija
        /// </summary>
        public void medirPresion()
        {
            Console.WriteLine("Medimos presion {0} vehiculo", marca);
        }
    }
}
