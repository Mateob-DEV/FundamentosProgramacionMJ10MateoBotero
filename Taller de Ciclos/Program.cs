using System;

namespace Taller_de_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1 ejercicio
            double sumaCalificaciones = 0;
            int cantidadCalficaciones = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingresa una calificación:");
                double calificacion = double.Parse(Console.ReadLine());

                sumaCalificaciones += calificacion;
                cantidadCalficaciones++;

                Console.WriteLine("¿Deseas ingresas otra calificación? (Si o no):");
                respuesta = Console.ReadLine();
            } while (respuesta == "si" || respuesta == "Si");

            if (cantidadCalficaciones > 0)
            {
                double promedio = sumaCalificaciones / cantidadCalficaciones;
                Console.WriteLine($"\nEl promedio de las {cantidadCalficaciones} calificaciones ingresadas es {promedio:F2}");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron calificaciones.");
            }

            Console.WriteLine("\n\nPresiona cualquier tecla para salir");
            Console.ReadKey();*/


            //------------------------------------------------------------------------------------------

            /*//2
            Console.WriteLine("Por favor ingresa un número para encontrar sus divisores:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos divisores de {numero} son:");

            for (int i = numero; i >= 1; i--)
            {
                if(numero % i == 0)
                {
                    Console.WriteLine($"{i} ");
                }
            }
            Console.WriteLine("\n\nPresiona cualquier tecla para salir");
            Console.ReadKey();*/


            //-------------------------------------------------------------------------------------------------


            /*//3
            string opcion;

            do
            {
                Console.WriteLine("Ingrese¿a la base (b):");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el exponente (e):");
                int e = int.Parse(Console.ReadLine());

                long resultado = 1;

                for (int i = 1; i <= e; i++)
                {
                    resultado *= b;
                }

                Console.WriteLine($"\nEl resultado de {b}^{e} es: {resultado}");


                Console.WriteLine($"\n¿Deseas realizar otra potencia? (Presiona 'n' para salir u otra tecla para continuar):");
                opcion = Console.ReadLine();

            } while (opcion != "n" && opcion != "N");

            Console.WriteLine($"\nPrograma finalizado.");
            Console.ReadKey();*/


            //------------------------------------------------------------------------------------------------------------

        }
    }
}
