namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosD5 = new int[CapturarFilas(), CapturarColumnas()];

        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el numero de filas para la matriz");
            int filas=Convert.ToInt32(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el numero de columna para la matriz");
            int columnas = Convert.ToInt32(Console.ReadLine());
            return columnas;
        }

        static int[,] LlenarMatriz(int[,] matriz)
        {

            return matriz;
        }   
    }
}
