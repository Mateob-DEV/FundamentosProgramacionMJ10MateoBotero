using System;


namespace _15.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales o matrices
            int[,] numeros = new int[2, 3];

            //numeros[2, 1] = 10; no se puede almacenar porque el indice de la fila no existe
            //numeros [1, 3] = 15; no se puede alamcenar porque el indice la columna no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 13;
            numeros[0, 2] = 14;
            numeros[1, 0] = 15;
            numeros[1, 1] = 16;
            numeros[1, 2] = 17;

            Console.WriteLine($"El valor almacenado en numeros[1,0]: {numeros[1, 0]}");
            //Recorrer para llenar
            char[,] simbolos = new char[3, 2];
            for (int i = 0; i < 3; i++)//Recorrer las filas
            {
                for (int j = 0; j < 2; j++)//Recorrer las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos[{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }
            //Recorrer para recuperar datos
            Console.Clear();
            for (int i = 0; i < simbolos.GetLength(0); i++)//GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//GetLenght(1) devuelve el numero de columnas
                {
                    Console.Write($"{simbolos[i, j]} |");

                }
                Console.WriteLine();
            }

            //otra forma de declarar e inicializar matrices en c#
            string[,] nombres = {
                                    {"Ana","Juan","Carlos","Alvaro" },
                                    {"Pedro","Ferney","Yuli","Felix" },
                                    {"Carla","Alez","Esteban","Salome" }
                                 };



            //1.Crear una matriz[10,20], en cada posicion de la matriz poner el numero 100; mostrar la matriz en consola
            //2. Escribir un programa que realice la suma de dos matrices de dimensiones 2x3
            //Requisitos del Programa:
            //- solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3)
            //- Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            //Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas).

        }
    }
}
