using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S8_CLASES1.Interfaces;

namespace S8_CLASES1.Entidades
{
    public class Jugador : Persona, ISancion
    {
        #region PROPERTIES
        private int infracciones;

        public int Infracciones { get => infracciones; set => infracciones = value; }
        #endregion

        public Jugador(string nombre, string apellido, int edad, string posicion) : base(nombre, apellido, edad, posicion)
        {
            this.infracciones = 0;
        }

        public override void Correr()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta corriendo");
        }

        public override void Precalentar()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta precalentando");
        }

        public void TarjetaAmarilla()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta AMARILLA");
        }

        public void TarjetaRoja()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta ROJA");
        }

        public void Falta()
        {
            Console.WriteLine($"El JUGADOR {Apellido} cometió una FALTA");
        }
    }
}
