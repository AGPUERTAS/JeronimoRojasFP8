namespace _21._For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que suma los primeros 5 numeros enteros

            int acumulador = 0 ;

            for(int i=1; i<=5; i++)
            {
                acumulador=+i ;
            }
            
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");
        }
    }
}
