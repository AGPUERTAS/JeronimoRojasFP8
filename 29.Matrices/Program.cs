namespace _29.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
             pantalla la suma de los elementos de cada columna.*/


            /*int[,] numeros = new int[4, 4];
            int[] SumaColumnas = new int[numeros.GetLength(1)];

            //Recorrer la matriz para llenarlla
            for(int i = 0; i < numeros.GetLength(0); i++)//Filas 
            {
                for(int j = 0; j < numeros.GetLength(1); j++)//columnas
                {
                    Console.WriteLine($"Ingrese el valor para la posicion {i},{j}");
                    numeros[i,j]=int.Parse(Console.ReadLine());

                }
            
            }

            //Recorrer l amatriz para mostrarla en pantalla
            for(int i = 0;i < numeros.GetLength(0); i++)
            {
                for (int j = 0;j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i,j]}  |");
                }
                Console.WriteLine();
            }

            //Recorrer laa matriz para samunar los elementos de cada columna

            for (int i = 0;i < numeros.GetLength(1); i++)
            {
                for( int j = 0; j<numeros.GetLength(0); j++)
                {
                    SumaColumnas[i] += numeros[j,i];
                }
            }

            //recorrer el vector y mostrar la suma de cada columna

            for( int i = 0; i<SumaColumnas.Length; i++)
            {
                Console.Write($"{SumaColumnas[i]}  |");
            }*/

            /*2.Desarrollar un programa que crea una matriz de n filas* m columnas, el usuario ingresa
              caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
              primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
              matriz con el intercambio de filas.*/

            string[,] caracteres = new string[4, 4];

            for(int i = 0; i<caracteres.GetLength(1); i++)
            {
                for(int j=0; j<caracteres.GetLength(0); j++)
                {
                    Console.WriteLine($"Por favor ingrese caracters para la posicionn {i},{j}: ");
                    caracteres[i, j] = Console.ReadLine();
                }
            } 

            for(int i = 0; i < caracteres.GetLength(1); i++)
            {
                for(int j=0; j < caracteres.GetLength(0); j++)
                {
                    
                }
            }
        }
        
    }
}
