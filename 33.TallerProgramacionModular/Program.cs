namespace _33.TallerProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[CapturarColumnas().Length];
            LlenarVector(palabras);
            MostrarVector(palabras);
        }
        static void MostrarVector(string[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} |");
            }
            Console.WriteLine();
        }

        static string[] LlenarVector(string[] vector)
        {
            string palabra;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Por favor ingrese la palabra deseada para ingresar al vector");
                palabra = Console.ReadLine();
            }
            return vector;
        }

        static string CapturarColumnas()
        {
            Console.WriteLine("Ingrese la palabra que desea analizar");
            string columnas = Console.ReadLine();
            return columnas;
        }
    }
}
