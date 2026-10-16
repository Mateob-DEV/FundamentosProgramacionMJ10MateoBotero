using System;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = CapturarFilas();
            int columnas = CapturarColumnas();

            int[,] matriz = new int[filas, columnas];

            BorrarPantalla();
            LlenarMatriz(matriz);
            MostrarMatriz(matriz);

            Console.ReadKey();
        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese la cantidad de filas:");
            return int.Parse(Console.ReadLine());
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese la cantidad de columnas:");
            return int.Parse(Console.ReadLine());
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void LlenarMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int numero;
                    do
                    {
                        Console.WriteLine($"Ingrese un múltiplo de 5 para la posición [{i},{j}]:");
                        numero = int.Parse(Console.ReadLine());

                        if (!EsMultiplo(numero, 5))
                        {
                            Console.WriteLine("El número ingresado NO es múltiplo de 5. Intente de nuevo.\n");
                        }

                    } while (!EsMultiplo(numero, 5));

                    matriz[i, j] = numero;
                }
            }
        }

        static bool EsMultiplo(int numero, int multiplo)
        {
            return numero % multiplo == 0;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("\n--- MATRIZ INGRESADA ---");
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}