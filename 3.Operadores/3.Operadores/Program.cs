using System;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Orden de evaluacion operadores numericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3f * 2f;
            float dato3 = 4f * (2f / 3f);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);

            Console.WriteLine(dato5);


            //Operadores Logicos:
            //Conjuncion - AND - Y - &&
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tabla de conjuncion");
            Console.WriteLine("V && V =" + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));
            Console.WriteLine("---------------------------");

            //Disyuncion - OR - O ||
            Console.WriteLine("Tabla de Diyuncion");
            Console.WriteLine("V || V =" + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));
            Console.WriteLine("---------------------------");

            //Negacion - no - !
            bool dato6 = true;
            bool dato7 = !dato6;


            //Operadores de comparacion:
            bool dato8 = 5 > 4;
            bool dato9 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;
        }
    }
}
