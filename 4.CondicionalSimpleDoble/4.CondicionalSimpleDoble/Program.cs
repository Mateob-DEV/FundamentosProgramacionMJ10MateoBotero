using System;


namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicional.
            //Condicional simple:
            //1. crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 años, se debe mostrat el siguiente mensaje: "Bienvenidos a mi sitio web".

            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi pagina web");
            }*/

            //Crear un algoritmo que permite ingresar el nombre y el sueldo de una persona,  si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.

            /*float sueldo = 0;
            string nombre = String.Empty;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + "Debe abonar impustos");
            }*/

            //Crea un algortitmo que lea la edad de un usuario, si el usuario es mayor de 18 años, se debe mostrar el siguiente mensaje: "bienvenido a mi sitio web". De lo contrario, mostrar el mensaje "No es apto para el contenido de este sitio web".


            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi pagina web");
            }
            else
            {
                //Si la condicion No se cumple
                Console.WriteLine("No es apto para el contenido del sitio web");
            }*/

            //Crear un algoritmo que permite ingresar el nombre y el sueldo de una persona,  si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos, De lo contrario mostrar el mensaje "perona exenta de impuestos"

            /*float sueldo = 0;
            string nombre = String.Empty;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " " + "Debe abonar impustos");
            }
            else
            {
                Console.WriteLine(nombre + " " + "Exento de impuestos");
            }*/

            //Crear un algoritmo que permita ingresar dos numeros, si el primer numero es mayor al segundo numero informar su suma y diferencia, en caso contrario informar el producto y la division del primer numero respecto al segundo numero.

            float numero1 = 0;
            float numero2 = 0;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToSingle(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine($"La suma es: {numero1 + numero2}, la resta es: {numero1 - numero2}");
            }
            else
            {
                Console.WriteLine($"La multiplicacion es: {numero1 * numero2}, la division es: {numero1 / numero2}");
            }




        }
    }
}
