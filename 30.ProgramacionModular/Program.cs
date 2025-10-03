namespace _30.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Jeronimo");
            //MostrarMensajes("Tengo 19 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2006)} años");
        }

        //modulo 1 - Procemiento
         static void MostrarMensaje()
         {
            Console.WriteLine("Bienvenidos a programacion modular");
            MostrarMensajes("Estoy desde Procedimiento sin parametros");

         }

        //modulo 2 - Procedimiento con parametros

        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Modulo 3 - Funciones sin parametros

         static int CalcularEdad()
         {
            int edad;
            edad = 2025 - 2006;
            return edad;
         }

        //modulo 4 - Funcion con parametros

        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
