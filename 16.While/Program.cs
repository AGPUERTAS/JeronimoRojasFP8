namespace _16.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. 

            
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intento = 0;
            int intentosRealizados = 0;

            Console.WriteLine("=== JUEGO: ADIVINA EL NÚMERO ===");
            Console.WriteLine("He elegido un número entre 1 y 100.");
            Console.WriteLine("¡A ver si puedes adivinarlo!\n");

            
            while (intento != numeroSecreto)
            {
                intentosRealizados++;

                
                Console.Write($"Intento #{intentosRealizados}: ");
                intento = Convert.ToInt32(Console.ReadLine());

                
                if (intento == numeroSecreto)
                {
                    Console.WriteLine($"\n¡FELICIDADES! ¡Has adivinado el número!");
                    Console.WriteLine($"El número era: {numeroSecreto}");
                    Console.WriteLine($"Lo lograste en {intentosRealizados} intentos.");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("El número es MAYOR. ¡Sigue intentando!");
                }
                else
                {
                    Console.WriteLine("El número es MENOR. ¡Sigue intentando!");
                }
            }

            Console.WriteLine("\n¡Juego terminado!");
        }
    }
}
