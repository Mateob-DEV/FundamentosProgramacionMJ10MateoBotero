using System;


namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Arreglos bidimensionales
            int[,] numeros=new int[2,3];// la coma indica dos dimensiones. Esta matriz tiene 2 filas y 3 columnas. LOs indices inicializan en 0

            //El rango de una matriz esta dado por el numero de filas por el numero de columnas. es este caso 2x3 = 6

            //numeros[2,1]= 23; No se puede almacenar porque las filas tienen indice 0 y 1. 2 se sale del rango del indice
            //numeros[1,3]= 54; Las columnas se salen del rango del indice.
            numeros[0, 0] = 25;
            numeros[0, 1] = 41;
            numeros[0, 2] = 104;
            numeros[1, 0] = 47;
            numeros[1, 1] = 56;
            numeros[1, 2] = 0;

            Console.WriteLine($"El valor almacenado en numeros[1,1] es: {numeros[1,1]}");

            char[,] simbolos = new char[2,3];

            //Recorrer para llenar (de izquierda a derecha y de arriba a abajo)
            for (int i=0;i<3;i++)//Recorre las filas
            {
                for (int j=0;j<2;j++)//Recorre las columnas, LAS VARIABLES DE LOS FOR DEBEN SER DISTINTAS.
                {
                    Console.WriteLine($"ingrese el caracter para simbolos [{i},{j}]");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
                //Hasta que j no alcance su valor maximo, i no cambia de valor.
            }

            Console.Clear();

            //Recorrer para recuperar
            for (int i=0;i<simbolos.GetLength(0);i++)//GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//GetLenght(2) devuelve el numero de columnas
                {
                    Console.Write($"{simbolos[i,j]}");
                }
                Console.WriteLine();//Vacio, para que cuando cambie de fila solamente cambie de linea
            }

            //otra forma de declarar e inicializar matrices.

            string[,] nombres =
            {

                { "Ana","vale","kami"},
                { "maria","negro","mauricio"},
                { "Jose","si","no"}
                //3 filas, 3 columnas. Es una manera mas visual de inicializar los datos

            }; //importante el ;
*/

            //Crear una matriz [10,20] en cada posicion poner el numero 100, mostrar matriz en la consola

            /*   int[,] cienes = new int[10, 20];

               for (int i =0; i <10; i ++)
               {
                   for (int j=0; j<20; j++)
                   {
                       cienes[i,j] = 100;
                   }
               }

               for (int i = 0; i < cienes.GetLength(0); i++)
               {
                   for (int j = 0; j < cienes.GetLength(1); j++)
                   {
                       Console.Write($"{cienes[i,j]} |");
                   }
                   Console.WriteLine();
               }*/

            //2. 

            int[,] pMatriz = new int[2, 3];
            int[,] sMatriz = new int[2, 3];
            int[,] sumaMatriz = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la primera matriz en los indices {i} , {j}");
                    pMatriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la segunda matriz en {i} , {j}");
                    sMatriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumaMatriz[i, j] = pMatriz[i, j] + sMatriz[i, j];
                }
            }

            for (int i = 0; i < sumaMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < sumaMatriz.GetLength(1); j++)
                {
                    Console.Write($"{sumaMatriz[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
