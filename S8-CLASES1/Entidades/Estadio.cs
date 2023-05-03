using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES1.Entidades
{
    public class Estadio
    {
        #region PROPS
        private string nombre;
        private string pais;
        private int capacidad;

        public Seleccion local;
        public Seleccion visitante;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        #endregion

        public Estadio(string nombre, string pais, int capacidad)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.capacidad = capacidad;            
        }

        /// <summary>
        /// Metodo que realiza el partido entre las Seleciones LOCAL  y VISITANTE  y returna el nombre de la ganadora
        /// </summary>
        /// <param name="l"></param>
        /// <param name="v"></param>
        /// <returns>Si empatan, retorna "EMPATE", caso contrario el nombre de la seleccion ganadora</returns>
        public string Cotejo(Seleccion l, Seleccion v) {
            string resultado = "empate";
            local = l;
            visitante = v;
            
            Random rnd = new Random();

            int golesL = rnd.Next(10);
            int golesV = rnd.Next(10);

            if (golesL > golesV)
            {
                resultado = l.Nombre;
            }
            else if(golesV > golesL){
                resultado = v.Nombre;
            }

            return resultado;
        }
    }
}
