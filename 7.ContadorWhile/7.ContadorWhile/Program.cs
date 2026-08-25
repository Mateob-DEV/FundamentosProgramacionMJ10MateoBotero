using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ContadorWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Escribir un algoritmo que permita generar los primeros 5 numeros enteros positivos y realizar y mostrar su suma.

            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador = acumulador + contador;
                contador++;
            }

            Console.WriteLine($"la suma de los cinco primeros numeros enteros es: {acumulador}");*/





            //2. Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario. (5! = 1*2*3*4*5)

            int numero;
            int contador = 1;
            int factorial = 1;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                factorial = factorial * contador;
                contador++;
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial} ");
        }
    }
}
