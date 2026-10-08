using System;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static float Division()
        {
            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }

        static float Resta()
        {
            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }

        static float Multiplicacion()
        {
            float multiplicaion = 1;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                multiplicaion *= numero;
                Console.WriteLine("Quiere seguir multiplicando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicaion;

        }

        static float Suma()
        {
            float suma = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Quiere seguir sumando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }

        static void RealizarOperaciones(int opcion)
        {
            while (opcion !=0)
            {





                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La Suma de los numeros ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La Resta de los numeros ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La Multiplicacion de los numeros ingresados es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La Division de los numeros ingresados es: {Division()}");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
        }

            static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }

        static void MostrarMenu()
        {
            Console.WriteLine("--------------------Menu---------------------");
            Console.WriteLine("1. Suma                    2. Resta");
            Console.WriteLine("3. Multiplicacion          4. Division");
            Console.WriteLine("0. Salir");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Ingrese una opcion del menu:");
        }
    }
}
