using System.Net;
using System.Security.Cryptography;

namespace _21.TallerPreparacioParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
                le permitirá al usuario, introducir tantas calificaciones como así desee, 
                en el momento en que seleccione que no desea continuar capturando
                calificaciones, el algoritmo debe presentar el promedio de las
                calificaciones capturadas previamente.*/

            /*float calificaciones = 0;
            int contador = 0;
            string respuesta = " ";
            float resultadoNotas = 0;

            do
            {


                Console.WriteLine("Por favor ingrese la calificacion");
                calificaciones = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Desea ingresar otra nota? s:si  n:no");
                respuesta = Console.ReadLine().ToLower();

                resultadoNotas+=calificaciones;
                contador++;

            } while (respuesta=="s");

            
            Console.WriteLine($"El promedio de las calificaciones es, {resultadoNotas/contador}");*/

            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un
                número ingresado por teclado.
                Tener en cuenta que dados dos números enteros a y b, se dice que b es
                divisor de a si se cumple que al efectuar una división entera a/ b el
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
                una división de dos números.*/


            /*3.Dados dos números enteros ingresados por teclado: b que es la base y
                e que es el exponente, se requiere calcular el resultado de la
                potenciación.
                Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
                Mostrar por pantalla el resultado de la potenciación. 
                Seguir pidiendo por teclado la base y el exponente y realizar la
                potenciación correspondiente, hasta que el usuario ingrese por teclado
                el carácter de escape ‘n’*/

            int Base = 0;
            int exponente = 0;
            string respuesta = " ";

            do
            {
                Console.WriteLine("Por ingrese la base");
                Base=int.Parse(Console.ReadLine());
                Console.WriteLine("Por ingrese el exponente");
                exponente = int.Parse(Console.ReadLine());

                Console.WriteLine($"b: {Base} X e: {exponente} = {Base*exponente}");

            } while (respuesta == "s");

        }
    }
}
