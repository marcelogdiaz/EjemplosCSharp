using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S8_CLASES1.Entidades;

namespace S8_CLASES1
{
    //Jugador       //CLASE
    //entrenador    //ATtr de la seleccion - CLASE
    //referi        //CLASE
    //Seleccion        //CLASE
    //pais          //ATTR de la Seleccion  - CLASE
    //posicion      //ATTR del jugador y del referi
    //estadio       //CLASE
    //camiseta      //ATTR de la Seleccion
    //mundiales ganados //ATTR de la Seleccion
    //goles favor       //ATTR de la Seleccion
    //goles en contra   //ATTR de la Seleccion
    //infracciones      //ATTR del jugador

    public class Program
    {
        static void Main(string[] args)
        {
            Estadio e1, e2;
            e1 = new Estadio("Maracana", "Brasil", 80000);
            e2 = new Estadio("Bombonera", "Argentina", 65000);

            Seleccion seleccionArgentina;
            Seleccion seleccionBrasilera;
            Jugador j10 = new Jugador("Lionel", "Messi", 36, "delantero");

            seleccionArgentina = new Seleccion("Scaloni","Argentina","Argentina","CelesteYBlanca");
            seleccionBrasilera = new Seleccion("Tite", "Brasil", "Brasil", "VerdeAmarella");

            seleccionArgentina.AgregarJugador(j10);
            seleccionArgentina.AgregarJugador(new Jugador("Dibu","Martinez",33,"arquero"));

            seleccionBrasilera.AgregarJugador(new Jugador("Junior", "Neymar", 28, "delantero"));
            seleccionBrasilera.AgregarJugador(new Jugador("Filip", "Coutinho", 28, "delantero"));

            foreach (Jugador j in seleccionArgentina.plantel) {
                Console.WriteLine($"{j.Apellido} - {j.Edad} - {j.Posicion}");
            }

            Console.WriteLine("PRIMERA RONDA");
            Console.WriteLine ("RESULTADO: "+ e1.Cotejo(seleccionBrasilera, seleccionArgentina));
            Console.ReadLine();

            Console.WriteLine("SEGUNDA RONDA");
            Console.WriteLine("RESULTADO: " + e2.Cotejo(seleccionArgentina, seleccionBrasilera));
            Console.WriteLine("presione enter ");
            Console.ReadLine();

        }
    }
}
