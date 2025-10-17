using System.Net;

namespace _3._5CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/

            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());//tambien sirve Convert.ToInt32(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //falsa
                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.*/

            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi pagina web");
            }
            else
            {
                Console.WriteLine("No eres apto para el contenido de esta pagina web");
            }

            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.*/

            int numero1 = 0;
            float numero2 = 0;

            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"La suma entre el primer numero y el segundo es {numero1 + numero2}");
                Console.WriteLine($"La resta entre el primer numero y el segundo es {numero1 - numero2}");
            }
            else
            {
                Console.WriteLine($"La multiplicacion entre el primer numero y el segundo es {numero1 * numero2}");
                Console.WriteLine($"La divicion entre el primer numero y el segundo es {numero1 / numero2}");
            }

            int numeroDeNoches = 0;
            int precioPorNoche = 200;
            int totalPagar = 0;
            int descuento = 0;

            Console.WriteLine("Cuantas noches desa hospedarse");
            numeroDeNoches=Int32.Parse(Console.ReadLine());
            

            if(numeroDeNoches > 3)
            {
                Console.WriteLine($"Usted obtendra un descuento del 17%, por lo tanto el total de la cuenta es {numeroDeNoches * precioPorNoche*0.17} dolares");
            }
            else
            {
                Console.WriteLine($"Usted obtendra un descuento del 2%, por lo tanto el total de la cuenta es {numeroDeNoches*precioPorNoche*0.02}");
            }

        }
    }
}
