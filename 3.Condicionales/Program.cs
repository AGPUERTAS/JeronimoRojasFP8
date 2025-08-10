namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.


            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine(); //todo lo que se lee desde la consola llega como un string

            
            Console.WriteLine("Ingrese el valor de su sueldo");
            sueldo=Convert.ToInt32 (Console.ReadLine());//convertir el string en valor entero

            if (sueldo>3000)
            {
                Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
                
            }

            //2.Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”.

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32 (Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
        }
    }
}
