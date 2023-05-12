using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES2.Entidades
{
    public class Moto : Vehiculo    //Heredamos de la clase VEHICULO
    {

        string color;

        /// <summary>
        /// Constructor de la clase
        /// BASE significa que llama al constructor de la clase PADRE
        /// </summary>
        /// <param name="m"></param>
        /// <param name="cantRuedas"></param>
        public Moto(string m, int cantRuedas, string c) : base(m, cantRuedas)
        {
            this.color = c;

        }

        /// <summary>
        /// Metodo que implementa la interfaz y redefine el mismo metodo de la clase PADRE
        /// </summary>
        public override void alinear()
        {
            Console.WriteLine("Alineamos MOTO {0}", marca);
        }

        /// <summary>
        /// Metodo que implementa la interfaz y redefine el mismo metodo de la clase PADRE
        /// </summary>
        public override void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} rueda {1} en MOTO", cantidadRuedas, marca);
        }

        public void medirPresion() {
            Console.WriteLine("Medimos presion {0} moto", marca);
        }

    }
}
