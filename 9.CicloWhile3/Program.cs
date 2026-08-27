using System;


namespace _9.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir.
            //El algoritmo debe escribir en pantalla: la cantidad de numeros introducidos que son mayores que 0, la cantidad de numeros introducidos que son menores que 0, y la cantidad de numeros iguales a 0.

            /*int numeros = 0;
            int cantidad = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;



            Console.WriteLine("ingrese la cantidad de numeros a evaluar");
            cantidad = int.Parse(Console.ReadLine());

            while (contador < cantidad)
            {
                contador++;
                Console.WriteLine("ingrese el numero a evaluar");
                numeros = int.Parse(Console.ReadLine());

                if (numeros > 0)
                {
                    contadorPositivos++;
                }
                else
                {
                    if (numeros < 0)
                    {
                        contadorNegativos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                }
            }
            Console.WriteLine($"Cantidad de positivos:{contadorPositivos}, Cantidad de negativos:{contadorNegativos}, Cantidad de ceros:{contadorCeros}");*/

            //Escribir un algoritmo que cuente cuantos numeros pares hay en rango de numeros del 1 al numero n. (funcion mod en c#)

            int rango = 0;
            int contador = 1;
            int contadorPar = 0;

            Console.WriteLine("ingrese el numero que quiere evaluar");
            rango = int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPar++;
                    Console.WriteLine($"{contador} - ");
                }
                contador++;

            }
            Console.WriteLine($"La cantidad de numeros pares en el rango del 1 al {rango} es :{contadorPar}");

        }

    }
}
