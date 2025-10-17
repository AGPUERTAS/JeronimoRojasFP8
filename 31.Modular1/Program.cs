namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            LlenarMatriz(multiplosDe5);
            MorMatriz(multiplosDe5);
        }   

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MorMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]}   |" );
                }
                Console.WriteLine();
            }
        }
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int numero = 0;

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                     BorrarPantalla();
                     Console.WriteLine("Digite un numero para ingresar a la matriz: ");
                     numero= int.Parse(Console.ReadLine());

                    }while(EsMultiplo5(numero) == false);

                    matriz[i, j] = numero;
                }
            }


            return matriz;
        }   

        static bool EsMultiplo5(int numero)
        {
            if(numero % 5 == 0 && numero!=0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, debe digitar un numero multiplo de 5 ");
                return false;
            }
        }

        static int CapturarFilas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el numero de filas para la matriz");
            int filas=Convert.ToInt32(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el numero de columna para la matriz");
            int columnas = Convert.ToInt32(Console.ReadLine());
            return columnas;
        }

    }
}
