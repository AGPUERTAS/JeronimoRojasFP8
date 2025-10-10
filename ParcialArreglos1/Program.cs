namespace ParcialArreglos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] tableroUsuario = new char[8, 8];
            char[,] tableroReferencia = {
                {'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T'},
                {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                {'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T'}
            };

            char[] fichasValidas = { 'R', 'D', 'T', 'A', 'C', 'p', 'X' };


            Console.WriteLine("Las fichas validas para el tablero son Rey (R), Dama/Reina (D), Torre (T), Alfil (A), Caballo (C), Peón (p), Casilla vacía (X)");
            

            for (int i = 0; i<tableroUsuario.GetLength(0); i++)
            {
                 for(int j = 0; j<tableroUsuario.GetLength(1); j++)
                 {
                    Console.WriteLine($"Por favor ingrese la ficha para posicion {i},{j}: ");
                    tableroUsuario[i,j]=Convert.ToChar(Console.ReadLine());
                    char.ToUpper(tableroUsuario[i,j]);

                    while (!fichasValidas.Contains(tableroUsuario[i,j]))
                    {
                        Console.WriteLine("Ficha inválida. Por favor ingrese una ficha válida (R, D, T, A, C, p, X): ");
                        tableroUsuario[i,j]=Convert.ToChar(Console.ReadLine());
                    }
                }
            }
        }
    }
}
