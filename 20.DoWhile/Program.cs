using System.Security.Cryptography;

namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20.Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:
            El número de partidos perdidos
            El número de partidos empatados
            El número de partidos ganados
            El porcentaje de partidos perdidos
            El porcentaje de partidos empatados
            El porcentaje de partidos ganados*/

            int numeroDePartidos = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int partidosGanados = 0;
            int cantidad = 5;
            int respuesta = 0;

            do
            {
                Console.WriteLine("¿Gano el partido?");
                Console.WriteLine("1.si   2.no   3.Empate");
                respuesta=int.Parse(Console.ReadLine());

                if (respuesta == 1)
                {
                    partidosGanados++;
                }
                else if (respuesta == 2)
                {
                    partidosPerdidos++;
                }
                else
                {
                    partidosEmpatados++;
                }

                numeroDePartidos++;
            } while (numeroDePartidos<cantidad);

            Console.WriteLine($"De los, {cantidad} partidos gano {partidosGanados}, perdio {partidosPerdidos} y empato {partidosEmpatados}");

            Console.WriteLine($"Partidos Ganados - {((100*partidosGanados)/cantidad)}, Partdios Perdidos - {((100*partidosPerdidos)/cantidad)}, Partidos Empatados - {((100*partidosEmpatados)/cantidad)}");
            
            
        }
    }
}
