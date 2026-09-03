using System;

namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que le pida a un grupo de usuarios su nombre, numero de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            - Si el sueldo es mayor o igual 3.000.000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y "Es apto para el credito"
            - Si el saldo es menor a 3.000.000, sacar un mensaje que diga el nombre del usuario, el numero de cuenta, el saldo y " No es apto para el credito"
            El algoritmo debe permitir preguntar la informacion de usuarios, hasta que se le indique que ya no desea pregunar mas.
            Ademas, el algoritmo debe permitir mostrar el numero de usuarios a los que se le pregunto por la informacion, y debe mostrar el promedio de los saldos.*/

            float sueldo = 0;
            int cuenta = 0;
            string nombre;

            string continuar;
            int totalUsuarios = 0;
            float sumaSueldos = 0;

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de cuenta");
                cuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su sueldo");
                sueldo = float.Parse(Console.ReadLine());

                totalUsuarios++;
                sumaSueldos += sueldo;

                if (sueldo >= 3000000)
                {
                    Console.WriteLine("Usuario:" + nombre + " " + "Cuenta:" + cuenta + " " + "Sueldo:" + sueldo + " " + "Es apto para el credito");
                }
                else
                {
                    Console.WriteLine("Usuario:" + nombre + " " + "Cuenta:" + cuenta + " " + "Sueldo:" + sueldo + " " + "No es apto para el credito");
                }

                Console.WriteLine("\n¿Desea ingresar otro usuario? (s/n):");
                continuar = Console.ReadLine();

            } while (continuar == "s");


            Console.WriteLine("\n--- REPORTE FINAL ---");
            Console.WriteLine("Cantidad total de usuarios consultados: " + totalUsuarios);

            if (totalUsuarios > 0)
            {
                float promedioSueldos = sumaSueldos / totalUsuarios;
                Console.WriteLine("Promedio de los sueldos: " + promedioSueldos);
            }



            /* 2. Crear un algoritmo que:
            - Permita al usuario ingresar una contraseña.
            - Se repita hasta que ingrese la contraseña correcta (Por ejemplo: 1234).
            - Mostrar cuantos intento realizo.*/

            int contraseñaCorrecta = 1234;
            int intentos = 0;


            do
            {

                Console.WriteLine("ingrese la contraseña");
                contraseñaCorrecta = int.Parse(Console.ReadLine());
                intentos++;

            } while (contraseñaCorrecta != 1234);

            Console.WriteLine("Total de intentos: " + intentos);

        }
    }
}
