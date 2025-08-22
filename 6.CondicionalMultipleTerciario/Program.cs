using System.Reflection;
using System.Security.Cryptography;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de compra");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingerese el dia de la semana:l:lunes, m:Martes, x:Miercoles, j:Jueves, v:Viernes, s:Sabado, d:Domingo ");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sabado, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Por favor ingrese un dia valido");
                    break;


            }

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float numero1 = 0;
            float numero2 = 0;
            
            char operacion = ' ';

            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion que desea realizar: s:Suma, m:Multiplicacion, r:Resta, d:Division");
            operacion=Convert.ToChar(Console.ReadLine());

            switch (operacion)
            {
                case 's':
                    Console.WriteLine($"El total de la suma es {numero1 + numero2}");
                    break;
                case 'r':
                    Console.WriteLine($"El total de la resta es {numero1 - numero2}");
                    break;
                case 'm':
                    Console.WriteLine($"El total de la multiplicacion es {numero1 * numero2}");
                    break;
                case 'd':
                    Console.WriteLine($"El total de la divicion es {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("Ingrese una operacion valida");
                    break;
            }

            /*Diseñar un algoritmo que solicite al usuario un número del 1 al 12, correspondiente a un mes del año(1 para enero, 2 para febrero, etc.). El algoritmo debe mostrar en pantalla el nombre del mes seleccionado y la cantidad de días que contiene.*/

            int nombreMes = 0;
            char mes = ' ';

            Console.WriteLine("Ingrese el mes que desa consultar:e:Enero, f:Febrero, m:Marzo, a:Abril, y:Mayo, j:Junio, u:Julio, g:Agosto, s:Septiembre, o:Octubre, n:Noviembre, d:Diciembre");
            mes = Convert.ToChar(Console.ReadLine());

            switch (mes)
            {
                case 'e':
                    Console.WriteLine($"El mes seloccionado es Enero, el cual contiene 31 días");
                    break;
                case 'f':
                    break;
                case 'm':
                    break;
                case 'a':
                    break;
                case 'y':
                    break;
                case 'j':
                    break;
                case 'u':
                    break;
                case 'g':
                    break;
                case 's':
                    break;
                case 'o':
                    break;
                case 'n':
                    break;
                case 'd':
                    break;
            }
        }
    }
}
