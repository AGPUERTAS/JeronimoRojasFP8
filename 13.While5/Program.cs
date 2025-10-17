namespace While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.
                El algoritmo debe escribir en pantalla: 
                La cantidad de números introducidos que son mayores que 0 
                La cantidad de números introducidos menores que 0  
                La cantidad de números iguales a 0.*/


            int contador = 1;
            int cantidadNumeros = 0;
            int mayores = 0;
            int menores = 0;
            int iguales = 0;
            int numero = 0;
            

            Console.WriteLine("Por favor ingrese la cantida de numeros");
            cantidadNumeros=Convert.ToInt32(Console.ReadLine());


            while (contador<=cantidadNumeros)
            {
                Console.WriteLine("Por favor ingrese un numero entero: ");
                numero=Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    mayores++;  
                }
                else if(numero < 0)
                {
                    menores++;
                }
                else
                {
                    iguales++;
                }
                contador++;
            }

            Console.WriteLine($"La cantidad de numeros mayores que 0 es: {mayores}");
            Console.WriteLine($"La cantidad de numeros menores que 0 es: {menores}");
            Console.WriteLine($"La cantidad de numeros iguales que 0 es: {iguales}");

            
        }
    }
}
