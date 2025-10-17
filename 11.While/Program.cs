namespace _11.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 
            
            int suma = 0;
            int numero;

            Console.WriteLine("Ingrese números enteros positivos (ingrese un número negativo para terminar):");

            
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            
            while (numero >= 0)
            {
                suma += numero; 

                
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine($"La suma total de los números positivos ingresados es: {suma}");
        }
    }
    
}
