using System;
using System.ComponentModel.Design;
using System.Timers;

namespace ParcialCondicionalesJeronimoRojasRodriguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            char sala = ' ';
            char juego = ' ';

            double juego1 = 3.000f;
            double juego2 = 5.000;
            double juego3 = 7.000;
            double juego4 = 9.000;
            double juego5 = 7.000;
            double juego6 = 9.000;
            double juego7 = 10.000;
            double juego8 = 7.000;
            double juego9 = 5.000;
            double juego10 = 3.000;


            Console.WriteLine("Señr@ usauario, cual es su edad.");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 1)
            {
                Console.WriteLine("El usuario solo puede entrar a la sala 1");
                Console.WriteLine("En esta sala estan disponilbes los juegos 1 y 5 por favor selecione uno de los dos");
                juego = Convert.ToChar(Console.ReadLine());

                switch (juego)
                {
                    case '1':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego1}");
                        break;
                    case '5':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego5}");
                        break;
                    default:
                        Console.WriteLine("Por favor escoja una de los dos opciones disponibles");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"El usuario solo puede entrar a la sala 1");
                Console.WriteLine("En esta sala estan disponilbes los juegos 1 y 5 por favor selecione uno de los dos");
                juego = Convert.ToChar(Console.ReadLine());

                switch (juego)
                {
                    case '1':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego1}");
                        break;
                    case '5':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego5}");
                        break;
                }

            }

            if(edad < 6)
            {
                Console.WriteLine("Este usuario puede entrar a las sala 2");
                Console.WriteLine("En esta sala estan disponilbes los juegos 3 y 6 por favor selecione uno de los dos");
                juego = Convert.ToChar(Console.ReadLine());
                switch (juego)
                {
                    case '3':
                        Console.WriteLine($"Este juego cuenta con el precio de{juego3}");
                        break;
                    case '6':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego6}");
                        break;
                }
            }
            else if(edad <= 16)
            {
                Console.WriteLine("Este usuario puede entrar a la sala 2");
                Console.WriteLine("En esta sala estan disponilbes los juegos 3 y 6 por favor selecione uno de los dos");
                juego = Convert.ToChar(Console.ReadLine());
                switch (juego)
                {
                    case '3':
                        Console.WriteLine($"Este juego cuenta con el precio de{juego3}");
                        break;
                    case '6':
                        Console.WriteLine($"Este juego cuenta con el precio de {juego6}");
                        break;
                }
            }

            if (edad < 17)
            {
                Console.WriteLine("Por favor selecione entre la sala 3 y 4");
                sala=Convert.ToChar(Console.ReadLine());
                switch (sala)
                {
                    case '3':
                        Console.WriteLine("Usted a seleccionado la sala 3");
                        break;
                    case '4':
                        Console.WriteLine("Usted a seleccionado la sala 4");
                        break;

                }
            }
            else if (edad <= 25)
            {
                Console.WriteLine("Por favor selecione entre la sala 3 y 4");
                sala = Convert.ToChar(Console.ReadLine());
                switch (sala)
                {
                    case '3':
                        Console.WriteLine("Usted a seleccionado la sala 3");
                        break;
                    case '4':
                        Console.WriteLine("Usted a seleccionado la sala 4");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Este usuario puede entrar a la sala 5 ");
                Console.WriteLine("En esta sala estan disponilbes los juegos 9 y 10 por favor selecione uno de los dos");
                juego = Convert.ToChar(Console.ReadLine());
                switch (juego)
                {
                    case '9':
                        Console.WriteLine($"Este juego tiene un precio de {juego9}");
                        break;
                    case '0':
                        Console.WriteLine($"Este juego tiene un precio de {juego10}");
                        break;
                }
            }
        }
        
    }
}
