using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            string nombre="Jeronimo";
            const string iva = "19%";
            string apellidos = "Rojas Rodriguez";
            Console.Write("Bienvenido al curso de fundamentos de programaccion\n");
            nombre = "alejandro";
            //iva = "20%"; no puedo cambiar el valor de iva por ser una constante
            Console.Write("\t" + nombre + " " +  apellidos +" " + iva);
            Console.ReadKey();
        }
    }
}
