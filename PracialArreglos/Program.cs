namespace PracialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// Tablero de referencia para validación
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

            // Tablero que llenará el usuario
            char[,] tableroUsuario = new char[8, 8];

            Console.WriteLine("=== CONSTRUCCIÓN DE TABLERO DE AJEDREZ ===");
            Console.WriteLine("Fichas válidas:");
            Console.WriteLine("Rey (R), Dama/Reina (D), Torre (T), Alfil (A), Caballo (C), Peón (p), Casilla vacía (X)");
            Console.WriteLine("Ingrese las fichas posición por posición:");

            // Solicitar entrada del usuario para cada posición
            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    bool entradaValida = false;

                    while (!entradaValida)
                    {
                        Console.Write($"Posición [{fila},{columna}]: ");
                        string entrada = Console.ReadLine();

                        if (entrada == null || entrada.Length == 0)
                        {
                            Console.WriteLine("Error: Debe ingresar un carácter.");
                            continue;
                        }

                        char ficha = Char.ToUpper(entrada[0]);

                        // Validar si la ficha es válida
                        char[] fichasValidas = { 'R', 'D', 'T', 'A', 'C', 'P', 'X' };
                        bool fichaEsValida = false;
                        for (int i = 0; i < fichasValidas.Length; i++)
                        {
                            if (fichasValidas[i] == ficha)
                            {
                                fichaEsValida = true;
                                break;
                            }
                        }

                        if (!fichaEsValida)
                        {
                            Console.WriteLine("Error: Ficha no válida. Use: R, D, T, A, C, p, X");
                            continue;
                        }

                        // Validar si la ficha está en la posición correcta
                        if (ficha != tableroReferencia[fila, columna])
                        {
                            Console.WriteLine($"Error: En esta posición debe ir '{tableroReferencia[fila, columna]}'");
                            continue;
                        }

                        // Entrada válida
                        tableroUsuario[fila, columna] = ficha;
                        entradaValida = true;
                    }
                }
                Console.WriteLine($"--- Fila {fila} completada ---");
            }

            // Mostrar el tablero final
            Console.WriteLine("=== TABLERO DE AJEDREZ COMPLETADO ===");
            Console.WriteLine("  +---+---+---+---+---+---+---+---+");

            for (int fila = 0; fila < 8; fila++)
            {
                Console.Write($"{fila} |");

                for (int columna = 0; columna < 8; columna++)
                {
                    Console.Write($" {tableroUsuario[fila, columna]} |");
                }

                Console.WriteLine("  +---+---+---+---+---+---+---+---+");
            }

            Console.WriteLine("    0   1   2   3   4   5   6   7");





        }
    }
}
