namespace _26.Matricez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de matrices
            int[,] numeros = new int[2, 2];
            string[,] nombres= new string[2, 3];//rango = 6 posiciones
            

            //Asignacion de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            //numeros[1, 2] = 2; Error indice fuera del rango

            //Otra forma de declarar y inicializar matrices
            string[,] apellidos =
            {
                {"Rojas","Rodriguez" },
                {"Posso", "Acevedo" },
                {"Baena", "Moncada" }
            };

            //Recuperar datos de la matriz
            Console.WriteLine(apellidos[1, 1]);

            //Recorrer matrices - Almacenar datos
            char[,] caracteres = new char[3, 2];//Rango = 6
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion con indices {i},{j}:");
                    caracteres[i,j]=char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();


            //Recorrer la matrces - recuprar datos
            for(int i = 0; i < caracteres.GetLength(0); i++)
            //caracteres.GetLength(0) devuelve numero de filas
            {
                for(int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.Write($"{caracteres[i,j]}  |");
                }
                Console.WriteLine();
            }

            //Rango de la matriz
            Console.WriteLine(caracteres.Length);
        }
    }
}
