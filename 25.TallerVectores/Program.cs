using System.Net;
using System.Security.Cryptography;

namespace _25.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] Vector;//Declarando

             Vector = new int[15];//Incializado
             int mayor=0;
             int menor=0;

             for (int i=0; i<Vector.Length; i++)
             {
                 Console.WriteLine($"Ingrese el numero entero para la posicion {i+1}, con indice {i}:");
                 Vector[i] = int.Parse(Console.ReadLine());

                 if (i == 0)
                 {
                     mayor = Vector[i];
                     menor = Vector[i];
                 }
                 else
                 {
                     if (Vector[i]> mayor)
                     {
                         mayor=Vector[i];
                     }
                     if (Vector[i] <menor)
                     {
                         menor = Vector[i];
                     }
                 }
             }
             Console.Clear();

             for (int i=0; i<Vector.Length-1; i++)
             {
                 Console.Write(Vector[i] + " |");
             }

             Console.WriteLine($"\nEl numero mayor es {mayor}, el numero menor es: {menor}");*/

            /*2.Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
                orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            char[] vectorOriginal;
            char[] vectorInvertido;

            vectorOriginal = new char[6];
            vectorInvertido = new char[6];

            for(int i=0; i<vectorOriginal.Length; i++)
            {
                Console.WriteLine($"Por favor ingrese un caracter para la posicion {i+1}, con indice {i}:");
                vectorOriginal[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < vectorOriginal.Length; i++)
            {
                Console.Write($"{vectorOriginal[i]}" + " | ");
            }

            
        }
    }
}
