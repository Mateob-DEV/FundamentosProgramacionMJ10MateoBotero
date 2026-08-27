using System;


namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida numeros enteros positivos y los sume, hasta que se ingrese un numero entero negativo. Se debe mostrar por pontalla el total de la suma de los numeros ingresados.

            int acumulador = 0;
            int numero = 0;

            Console.WriteLine("ingrese el numero a sumar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                acumulador += numero;
                Console.WriteLine("ingrese el numero a sumar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los numeros ingresados es:{acumulador}");

            
            

        }
    }
}
