using System;


namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales multiples
            //Crear un algoritmo que muestre por pantalñla un menu con 5 opciones, y segun la opcion elegida del menu, muestre un mensaje por pantalla donde se mesutre la opcion elegida, en caso de que se seleccione una opcion que no este en el menu mostrar error.

            int respuesta = 0;
            Console.WriteLine("------------Menu----------");
            Console.WriteLine("1.opcion 1      2.opcion 2");
            Console.WriteLine("4.opcion 3      4.opcion 4");
            Console.WriteLine("5.opcion 5                ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elija una opcion del menu:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio la opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio la opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio la opcion 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio la opcion 5");
                    break;
                default:
                    Console.WriteLine("Eligio una opcion valida");
                    break;
            }

        }
    }
}
