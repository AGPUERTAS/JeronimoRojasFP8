namespace _18.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            1. Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto     para el crédito” 
           2. Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto   para el crédito” 
             El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
             Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.*/

            int usuario = 0;
            int numCuenta = 0;
            int saldo = 0;
            string respuesta=" ";

            do
            {
                Console.WriteLine("Nombre del usuario");
                usuario = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor ingrese el numero de cuenta");
                numCuenta=int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el saldo de dicha cuenta");
                saldo=int.Parse(Console.ReadLine());

                do
                {

                }while

            } while (respuesta);
           



        }
    }
}
