using System;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 

            Console.WriteLine("Adivina el número secreto entre 1 y 100:");
            int intento = int.Parse(Console.ReadLine());

            while (intento != numeroSecreto)
            {
                if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo:");
                }
                else
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
                }

                intento = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¡Correcto! Has adivinado el número secreto.");
        }
    }
}
