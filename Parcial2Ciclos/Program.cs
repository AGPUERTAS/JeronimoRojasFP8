using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Parcial2Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa para procesar las notas definitivas de Física de un grupo de 15 estudiantes.Las calificaciones están en un rango de 0.0 a 5.0.
              El programa debe realizar las siguientes tareas:
              Ingresar por teclado la nota final de cada estudiante.
              Calcular el promedio general del grupo.
              Clasificar a cada estudiante según su calificación en una de las siguientes categorías:
              Excelente: nota ≥ 4.8
              Bueno: 4.0 ≤ nota ≤ 4.7
              Regular: 3.0 ≤ nota ≤ 3.9
              Descuidado: nota ≤ 2.9
              Contar y mostrar por pantalla el número total de estudiantes en cada categoría.
              Mostrar en pantalla el promedio del grupo y la cantidad de alumnos clasificados en cada nivel.*/

            int estudiantes = 0;
            double nota = 0;
            double excelente = 0;
            double bueno = 0;
            double regular = 0;
            double descuidado = 0;
            float cantidad = 2;
            double respuesta = 0;

            do
            {
                Console.WriteLine("Que nota saco el estudiante");
                Console.WriteLine("1. 4.8 o mas, || 2. entre 4.0 y 4.7, || 3. entre 3.0 y 3.9, || y 4. 2,9 o menos ");
                respuesta=Convert.ToDouble(Console.ReadLine());

                if (respuesta == 1)
                {
                    excelente++;
                }
                else if (respuesta==2)
                {
                    bueno++;
                }
                else if(respuesta ==3)
                {
                    regular++;
                }
                else
                {
                    descuidado++;
                }
                estudiantes++;

                Console.WriteLine("Espesifique que nota saco el estudiante");
                nota=Convert.ToDouble(Console.ReadLine());
            }while (estudiantes<cantidad);

            Console.WriteLine($"En la categoria de excelente hay, {excelente} estudiantes  ");
            Console.WriteLine($"En la categoria de bueno hay, {bueno} estudiantes,");
            Console.WriteLine($"en la categoria de regulares hay, {regular} estudiantes");
            Console.WriteLine($"En la categoria de descuidados hay, {descuidado} estudiantes");

            Console.WriteLine($"Y el promedio total del grupo es - {((100*respuesta)/cantidad)}");
        }
    }
}
