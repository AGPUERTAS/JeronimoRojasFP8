namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1 * 2 * 3 * 4 * 5)

            int contador = 1; es una variable entera
            int acumulador = 1; es una variable numerica
            int num = 0;

            Console.WriteLine("Por favor ingrese el numero al que desa calcularle el factorial");
            num=Convert.ToInt32(Console.ReadLine());

             while (contador>=num)
            {
                acumulador *= contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }
            
            Console.WriteLine("el total delactorial es " + num);*/

            //12.Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.

            int contador = 1;
            int suma = 0;

            while (contador <= 99)
            {
                suma += contador;
                Console.WriteLine($"{contador} - {suma}");
                contador += 2;
            }

            Console.WriteLine($"La suma de los numeros impares hasta el 99 es: {suma}");

        }
    }
}
