using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales - Vectores
            int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            //numeros[5] = 11; No se puede porque la posicion 6 con indice 5 no existe.
            Console.WriteLine($"El numero almacenado en la posicion4 con indice 3 es:{numeros[3]}");
            //Otras formas de declarar e inicializar vectores
            char[] simbolosm = new char[] { '?', '/', 'o', '5', };
            bool[] valoresVerdad = { true, false, true, false, true, true };
            //Recorrer para llenar de datos el vector
            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingresa el nombre para la p{i + 1}:I{i}:");
                nombres[i] = Console.ReadLine();
            }
            //Recorrer para recuperar datos almacenados
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"{nombres[i]} |");
            }
            //Crea arreglo llamado "enteros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y mostrarlo en pantalla.
            int[] enteros = new int[100];
            //Algoritmo que permita solicitar 10 numeros, los cuales seran almacenados en un arreglo, al final, debe visualizar el promedio de esos numeros.
            int[] numeros = new int[10];
            /*Llene un arreglo con 15 numeros ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo.
            finalmente determine cual es el mayor y cual es el numero menor, junto con la posicion que ocupa cada uno del arreglo.*/
            int[] numeros = new int[15];
        }
    }
}
