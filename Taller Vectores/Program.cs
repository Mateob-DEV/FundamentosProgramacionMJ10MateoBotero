using System;


namespace Taller_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.-----------------------------------------------------


            /*int[] vector = new int[15];
           
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingresa el número para la posición {i + 1}:");
                vector[i] = int.Parse(Console.ReadLine());
            }
            
            int maximo = vector[0];
            int minimo = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }

                if (vector[i] < minimo)
                {
                    minimo = vector[i];
                }
            }

            Console.WriteLine($"\nEl valor máximo ingresado es: {maximo}");
            Console.WriteLine($"El valor mínimo ingresado es: {minimo}");*/






            //2.-------------------------------------------------------------
            /* Console.WriteLine("Ingresa el tamaño para los vectores:");
             int tamano = int.Parse(Console.ReadLine());

             int[] vector1 = new int[tamano];
             int[] vector2 = new int[tamano];

             Console.WriteLine("\n--- Llenando el primer vector ---");
             for (int i = 0; i < vector1.Length; i++)
             {
                 Console.WriteLine($"Ingresa el número para el Vector 1 (posición {i}):");
                 vector1[i] = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("\n--- Llenando el segundo vector ---");
             for (int i = 0; i < vector2.Length; i++)
             {
                 Console.WriteLine($"Ingresa el número para el Vector 2 (posición {i}):");
                 vector2[i] = int.Parse(Console.ReadLine());
             }

             int contadorIguales = 0;

             for (int i = 0; i < tamano; i++)
             {
                 if (vector1[i] == vector2[i])
                 {
                     contadorIguales++;
                 }
             }

             Console.WriteLine($"\nCantidad de elementos iguales en la misma posición: {contadorIguales}");*/





            //3.-------------------------------------------------------------------------------------
            /*int[] vector = new int[20];
            Random aleatorio = new Random();

            Console.WriteLine("¿Cómo deseas llenar el vector?");
            Console.WriteLine("1. Ingresar números manualmente por teclado");
            Console.WriteLine("2. Generar números aleatoriamente");
            Console.WriteLine("Selecciona una opción (1 o 2):");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine($"Ingresa el número entero para la posición {i}:");
                    vector[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    
                    vector[i] = aleatorio.Next(-50, 51);
                }
            }

            double suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            double promedio = suma / vector.Length;

            int mayoresPromedio = 0;
            int menoresPromedio = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > promedio)
                {
                    mayoresPromedio++;
                }
                else if (vector[i] < promedio)
                {
                    menoresPromedio++;
                }
            }

            Console.WriteLine("\n--- Elementos del vector ---");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {vector[i]}");
            }

            Console.WriteLine($"\nPromedio aritmético del vector: {promedio:F2}");
            Console.WriteLine($"Cantidad de números mayores que el promedio: {mayoresPromedio}");
            Console.WriteLine($"Cantidad de números menores que el promedio: {menoresPromedio}");*/






            //4.----------------------------------------------------------------------------------
            /*Console.WriteLine("Ingresa la cantidad de caracteres a guardar:");
            int tamano = int.Parse(Console.ReadLine());

            char[] original = new char[tamano];
            char[] invertido = new char[tamano];

            
            Console.WriteLine("\n--- Ingreso de caracteres ---");
            for (int i = 0; i < original.Length; i++)
            {
                Console.WriteLine($"Ingresa el carácter para la posición {i}:");
                original[i] = char.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < original.Length; i++)
            {
                invertido[i] = original[original.Length - 1 - i];
            }

            
            Console.WriteLine("\n--- Vector Original ---");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write($"[{original[i]}] ");
            }

           
            Console.WriteLine("\n\n--- Vector Invertido ---");
            for (int i = 0; i < invertido.Length; i++)
            {
                Console.Write($"[{invertido[i]}] ");
            }

            Console.WriteLine();*/




            //5.---------------------------------------------------------------------
            /*int[] vector = new int[20];
            Random aleatorio = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(0, 51);
            }

            Console.WriteLine("Ingresa un número entero entre 0 y 50 para buscar en el vector:");
            int numeroBuscado = int.Parse(Console.ReadLine());

            int posicionEncontrada = -1;

            
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numeroBuscado)
                {
                    posicionEncontrada = i;
                    break; 
                }
            }

            if (posicionEncontrada != -1)
            {
                Console.WriteLine($"\n¡Número encontrado! Se encuentra en la posición: {posicionEncontrada}\n");

               
                Console.WriteLine("--- Vector con el número resaltado ---");
                for (int i = 0; i < vector.Length; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"[{vector[i]}] ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"[{vector[i]}] ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"\nResultado: {posicionEncontrada} (El número no se encuentra en el vector).");
            }*/


        }
    }
}
