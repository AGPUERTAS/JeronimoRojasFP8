using System.Diagnostics;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Igrese el primer numero");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 == numero2 && numero2 == numero3 && numero1 == numero3)
            {
                Console.WriteLine("todos los numeros deben de ser diferentes");
            }
            else
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"El numero {numero1}, es el mayor");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero3}, es el mayor");
                    }
                }
                else
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine($"El numero {numero2}, es el mayor");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero3}, es el mayor");
                    }
                }
                Console.WriteLine("Los numeros ordenados de mayor a menor");

                if (numero1 < numero2 && numero1 < numero3)
                {
                    Console.WriteLine($"El primer numero es {numero1}, el segundo numero es {numero2}, el tercer numero es {numero3}");
                }
                else if (numero2 < numero1 && numero2 < numero3)
                {
                    Console.WriteLine($"El primer numero es {numero2}, el segundo numero es {numero3}, el tercer numero es {numero1}");
                }
                else
                {
                    Console.WriteLine($"El primer numero es {numero3}, el segundo numero es {numero2}, el tercer numero es {numero1}");
                }

            }



            /*2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
                cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
                a.Permita ingresar por teclado si el personaje está en estado invencible(True).
                b.La cantidad de munición que tiene el personaje en el momento será calculada por el
                sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
                 Ejemplo:
                 int numero;
                 Random rnd = new Random();
                 numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
                 Console.WriteLine(numero);
                 c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
                 10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
                 no hacer nada.*/

            bool invencible;
            int municion = 0;

            Console.WriteLine("¿El personaje esta en estado invesibles? true/false: ");
            invencible = bool.Parse(Console.ReadLine());

            Random rnd = new Random();
            municion = rnd.Next(1, 10);
            Console.WriteLine($"La cantidad de municion generada es {municion}");

            if (invencible == true && municion >= 1)
            {
                Console.WriteLine("El personaje esta dsiparando");
            }

            /*3.Crear un algoritmo que permita ingresar las coordenadas x, y, para tres puntos: P1(x1, y1), 
                P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 
                P3.La distancia entre dos puntos está dada por la siguiente formula:
                d = √((x2 - x1)² +(y2 - y1)²) 
                Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
                dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
                cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
                condiciones no se cumplen. */

            float P1 = 0;
            float P2 = 0;
            float P3 = 0;

            Console.WriteLine("Ingrese las coordenadas del punto 1");
            P1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto 2");
            P2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del punto 3");
            P3 = Convert.ToSingle(Console.ReadLine());

            /*4.El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), 
                crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
                hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
                 Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
                derecha
                 Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
                 En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
                  dirección”*/

            char movimiento = ' ';

            Console.WriteLine("Presiones d o i para realizar u movimiento");
            movimiento=Convert.ToChar(Console.ReadLine());

            switch (movimiento)
            {
                case 'd':
                    Console.WriteLine("El personaje se mueve a la derecha");
                    break;
                case 'i':
                    Console.WriteLine("El personaje se mueve a la izquierda");
                    break;
                default:
                    Console.WriteLine("No me puedo mover");
                    break;
                        

            }
        } 
    }
}
