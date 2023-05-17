using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S8_CLASES1.Interfaces;

namespace S8_CLASES1.Entidades
{
    public class Referi : Persona, ISancion
    {
        public Referi(string nombre, string apellido, int edad, string posicion) : base(nombre, apellido, edad, posicion)
        {
        }
        public override void Correr()
        {
            Console.WriteLine($"El REFERI {Apellido} esta corriendo");
        }

        public void Falta()
        {
            Console.WriteLine($"El REFERI {Apellido} cobró una FALTA");
        }

        public override void Precalentar()
        {
            Console.WriteLine($"El REFERI {Apellido} esta precalentando");
        }

        public void TarjetaAmarilla()
        {
            Console.WriteLine($"El REFERI {Apellido} sacó tarjeta AMARRILLA");
        }

        public void TarjetaRoja()
        {
            Console.WriteLine($"El REFERI {Apellido} sacó tarjeta ROJA");
        }
       
    }
}
