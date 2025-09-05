namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genere y calcule la suma de los 5 primeros numeros enteros positivos

            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador+=contador;
            }while (contador<5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/

            /*17.Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/

            int numero = 0;
            int contador = 1;
            string respuesta=" ";


            do
            {
                 Console.WriteLine("Por favor ingrese un numero");
                 numero=int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("Quiere genrar otra tabla de multiplicar: s:si - n:no");
                respuesta = Console.ReadLine().ToLower();

            }while(respuesta=="s");


        }
    }
}
