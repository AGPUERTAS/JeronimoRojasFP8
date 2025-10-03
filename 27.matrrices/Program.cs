namespace _27.matrrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*27.Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas).*/

            int[,] numeros = new int[2, 3];
            int[,] numeros2= new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingerese el numero para la posicion con indice {i},{j} de la priemra matriz:");
                    numeros[i,j]=int.Parse(Console.ReadLine());
                }
            }
            
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el numero para la posicion con indice {i},{j} de la segunda matriz:");
                    numeros2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            for( int i = 0; i < numeros.GetLength(0); i++)
            {
                for( int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i,j]} |");
                }
                Console.WriteLine();
            }  
        }
    }
}
