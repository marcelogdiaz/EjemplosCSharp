using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES1.Entidades
{
    public class Jugador
    {
        #region PROPERTIES
        private string nombre;
        private string apellido;
        private int edad;
        private string posicion;
        private int infracciones;

        public string Nombre { get => nombre; /*set => nombre = value; */}
        public string Apellido { get => apellido; /*set => apellido = value; */}
        public int Edad { get => edad; set => edad = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int Infracciones { get => infracciones; set => infracciones = value; }
        #endregion

        public Jugador(string nombre, string apellido, int edad,string posicion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.posicion = posicion;
            this.infracciones = 0;
        }

    }
}
