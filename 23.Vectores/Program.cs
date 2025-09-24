namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            //vectores

            int[] numeros = new int[5];//El vector numeros tiene cinco posiciones 
            string[] nombres=new string[4];

            for(int i=0;i<nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre para posicion {i + 1}, con inidce {i}: ");
                nombres[i] = Console.ReadLine();
                
            }

            for (int i = 0; i < nombres.Length; i++)//.Length devuelve el rango del vector
            {
                Console.Write(nombres[i] + " | ");
            }
           /* //Asiga valores a las posociones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] = 85; Error porque el indice 5 no esxiste

            int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21 };
            int[] numeros2 = { 5, 12, 4, 7, 9 };
            //Yo puedo recorrer el vector para llenarlo de datos o para recuperar datos
            char[] caracter = new char[4];
            
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion {i+1}, con indice {i}:");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posicion 3, tiene almacenado el dato: {caracter[2]}");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion {i + 1}, tiene almacenado el dato: {caracter[i]}");
                
            }

            for (int i = 0; i < caracter.Length; i++)//.Length devuelve el rango del vector
            {
                Console.Write(caracter[i] + " | ");
            }*/


        }
    }
}
