namespace _15.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double ahorroTotal = 0;
            double depositoMensual;
            int mes = 1;

            Console.WriteLine("=== CONTROL DE AHORRO ANUAL ===");
            Console.WriteLine("Ingrese el monto depositado cada mes:\n");

            
            while (mes <= 12)
            {
                
                Console.Write($"Depósito del mes {mes}: $");
                depositoMensual = Convert.ToDouble(Console.ReadLine());

                
                while (depositoMensual < 0)
                {
                    Console.WriteLine("Error: No se permiten depósitos negativos.");
                    Console.Write($"Ingrese nuevamente el depósito del mes {mes}: $");
                    depositoMensual = Convert.ToDouble(Console.ReadLine());
                }

               
                ahorroTotal += depositoMensual;

                Console.WriteLine($" Ahorro acumulado hasta el mes {mes}: ${ahorroTotal:F2}");
                

                
                mes++;
            }

            
            Console.WriteLine("\n=== RESUMEN ANUAL ===");
            Console.WriteLine($"Ahorro total en el año: ${ahorroTotal:F2}");
        }
    }
}
