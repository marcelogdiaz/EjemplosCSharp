using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES1.Entidades
{
    public class Seleccion
    {
        #region PROPS
        private string entrenador;
        private string pais;
        private string nombre;
        private string camiseta;
        private int mundialesGanados;
        private int golesAFavor;
        private int golesEnContra;
        //private int cantidadJugadores;

        public List<Jugador> plantel;
        #endregion

        public string Entrenador { get => entrenador; set => entrenador = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Camiseta { get => camiseta; set => camiseta = value; }
        public int MundialesGanados { get => mundialesGanados; set => mundialesGanados = value; }
        public int GolesAFavor { get => golesAFavor; set => golesAFavor = value; }
        public int GolesEnContra { get => golesEnContra; set => golesEnContra = value; }

        public Seleccion(string entrenador, string pais, string nombre, string camiseta)
        {
            this.Entrenador = entrenador;
            this.Pais = pais;
            this.Nombre = nombre;
            this.Camiseta = camiseta;
            this.MundialesGanados = 0;
            this.GolesAFavor = 0;
            this.GolesEnContra = 0;

            this.plantel = new List<Jugador>();
        }

        public void AgregarJugador(Jugador j) {
            plantel.Add(j);
        }


    }
}
