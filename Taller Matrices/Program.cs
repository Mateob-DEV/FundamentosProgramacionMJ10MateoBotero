using System;


namespace Taller_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.-------------------------------------------------------------------------------
            /*
            int[,] matriz = new int[10, 20];
            Random aleatorio = new Random();

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 10);
                }
            }

            
            Console.WriteLine("--- Matriz [10x20] ---");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n--- Suma por Columna ---");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int sumaColumna = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    sumaColumna += matriz[i, j];
                }

                Console.WriteLine($"Suma de la columna {j}: {sumaColumna}");*/

            //2.---------------------------------------------------------------------

            /*Console.WriteLine("Ingresa el número de filas (n):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el número de columnas (m):");
            int m = int.Parse(Console.ReadLine());

            char[,] matrizOriginal = new char[n, m];
            char[,] matrizIntercambiada = new char[n, m];


            Console.WriteLine("\n--- Ingreso de caracteres ---");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese el carácter para la posición [{i},{j}]:");
                    matrizOriginal[i, j] = char.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrizIntercambiada[i, j] = matrizOriginal[i, j];
                }
            }

            for (int j = 0; j < m; j++)
            {
                char temporal = matrizIntercambiada[0, j];
                matrizIntercambiada[0, j] = matrizIntercambiada[n - 1, j];
                matrizIntercambiada[n - 1, j] = temporal;
            }

            Console.WriteLine("\n--- Matriz Original ---");
            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    Console.Write($"{matrizOriginal[i, j]} |");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n--- Matriz Intercambiada (Primera y Última fila) ---");
            for (int i = 0; i < matrizIntercambiada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizIntercambiada.GetLength(1); j++)
                {
                    Console.Write($"{matrizIntercambiada[i, j]} |");
                }
                Console.WriteLine();*/

            //3.----------------------------------------------------------------------------------------------

            /*int[,] matriz = new int[5, 5];
            int[] frecuencias = new int[10]; 
            Random aleatorio = new Random();

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 11); 
                }
            }

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int numero = matriz[i, j];
                    frecuencias[numero - 1]++; 
                }
            }

           
            Console.WriteLine("--- Matriz [5x5] ---");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

           
            Console.WriteLine("\n--- Frecuencia de cada número (del 1 al 10) ---");
            for (int k = 0; k < frecuencias.Length; k++)
            {
                Console.WriteLine($"Número {k + 1}: se repite {frecuencias[k]} veces");
            }*/

            //4.-----------------------------------------------------------------------------------
            char[,] tablero = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = '-';
                }
            }


            Random aleatorio = new Random();
            int xColocadas = 0;

            while (xColocadas < 3)
            {
                int filaAleatoria = aleatorio.Next(0, 5);
                int columnaAleatoria = aleatorio.Next(0, 5);

                if (tablero[filaAleatoria, columnaAleatoria] != 'X')
                {
                    tablero[filaAleatoria, columnaAleatoria] = 'X';
                    xColocadas++;
                }
            }

            bool acerto = false;
            int filaAcertada = -1;
            int columnaAcertada = -1;


            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine($"--- Intento {intento} de 3 ---");
                Console.WriteLine("Ingresa el número de fila (0 a 4):");
                int fila = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el número de columna (0 a 4):");
                int columna = int.Parse(Console.ReadLine());


                if (tablero[fila, columna] == 'X')
                {
                    acerto = true;
                    filaAcertada = fila;
                    columnaAcertada = columna;
                    break;
                }
                else
                {
                    Console.WriteLine("No hay una 'X' en esa posición.\n");
                }
            }

            if (acerto)
            {
                Console.WriteLine($"\n¡ÉXITO! Has acertado la posición de una 'X' en los índices [{filaAcertada},{columnaAcertada}].");
            }
            else
            {
                Console.WriteLine("\n¡ERROR! Has agotado tus 3 intentos sin encontrar ninguna 'X'.");
                Console.WriteLine("\n--- Tablero con la ubicación de las 'X' ---");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"{tablero[i, j]} |");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

