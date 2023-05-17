using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES1.Entidades
{
    public abstract class Persona
    {
        #region PROPERTIES
        private string nombre;
        private string apellido;
        private int edad;
        private string posicion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        #endregion

        public Persona(string nombre, string apellido, int edad, string posicion) {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Posicion = posicion;
        }

        //abstract - override
        //virtual - override

        public abstract void Correr();

        public abstract void Precalentar();
    }
}
