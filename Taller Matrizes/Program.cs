using System;


namespace Taller_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];
            int[] frecuencias = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rnd.Next(1, 11);
                    switch (numeros[i, j])
                    {
                        case 1:
                            frecuencias[0]++;
                            break;
                        case 2:
                            frecuencias[1]++;
                            break;
                        case 3:
                            frecuencias[2]++;
                            break;
                        case 4:
                            frecuencias[3]++;
                            break;
                        case 5:
                            frecuencias[4]++;
                            break;
                        case 6:
                            frecuencias[5]++;
                            break;
                        case 7:
                            frecuencias[6]++;
                            break;
                        case 8:
                            frecuencias[7]++;
                            break;
                        case 9:
                            frecuencias[8]++;
                            break;
                        case 10:
                            frecuencias[9]++;
                            break;
                        default:
                            break;



                    }

                }
            }
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"{numeros[i, j]}");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (int i = 0; i < frecuencias.Length; i++)
            {
                Console.Write($"La freuencia del numero {i+1} es: {frecuencias[i]}");
            }

        }
    }
}
