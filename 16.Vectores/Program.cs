using System;


namespace _16.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[15];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingresa el número para la posición {i}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n--- Elementos del arreglo ---");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }

            int mayor = numeros[0];
            int posicionMayor = 0;

            int menor = numeros[0];
            int posicionMenor = 0;

            
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }

            Console.WriteLine($"\nEl número mayor es {mayor} y se encuentra en la posición {posicionMayor}.");
            Console.WriteLine($"El número menor es {menor} y se encuentra en la posición {posicionMenor}.");
        }
    }
}
