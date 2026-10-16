/* sing System;


namespace Taller_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor ingrese 3 valores diferentes");
            Console.WriteLine("Ingrese el número 1:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingese el número 3:");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Error: Debe ingresar valores diferentes.");
            }
            else
            {
                if (numero1 > numero2 && numero1 > numero3)
                {
                    Console.WriteLine("El número 1 es el mayor");
                }
                else if (numero2 > numero3 && numero2 > numero1)
                {
                    Console.WriteLine("El número 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }

               


            }
        }
    }
}
*/