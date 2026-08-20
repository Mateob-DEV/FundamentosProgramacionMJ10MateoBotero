using System;



namespace MateoParcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energia = 0;
            string usuario;
            int bajo = 0;
            int medio = 0;
            int alto = 0;
            int muyalto = 0;
            string nombre;
            int consumo;
            int valorBase = consumo * energia;
            int porcentaje = 0;
            int valorAjuste = 0;
            int total = 0;


            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de usuario (residencial/comercial):");
            usuario = Console.ReadLine();

            Console.WriteLine("¿Cual es su consumo mensual de energia?(kwh):");
            energia = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es su consumo mensual de energía? (kWh):");
            consumo = int.Parse(Console.ReadLine());






            if (usuario == "residencial")

            {
                energia = 800;
            }
            else if (usuario == "comercial")
            {
                energia = 1200;
            }
            else
            {
                Console.WriteLine("Tipo de usuario no válido.");
            }
            if (energia > 0)
            {
                Console.WriteLine("El valor a cobrar es: " + energia);
            }
            else
            {
                Console.WriteLine("Error: el consumo debe ser mayor que 0");
            }


            string categoria = "";
          

            if (consumo <= 100)
            {
                bajo = consumo;
                categoria = "Bajo";
            }
            else if (consumo > 100 && consumo <= 200)
            {
                medio = consumo;
                categoria = "Medio";
            }
            else if (consumo > 200 && consumo <= 400)
            {
                alto = consumo;
                categoria = "Alto";
            }
            else if (consumo > 400)
            {
                muyalto = consumo;
                categoria = "Muy alto";
            }

          
         

            
            if (usuario == "residencial")
            {
                if (categoria == "Bajo")
                {
                    porcentaje = 10;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase - valorAjuste;
                }
                else if (categoria == "Medio")
                {
                    porcentaje = 5;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase - valorAjuste;
                }
                else if (categoria == "Alto")
                {
                    porcentaje = 0;
                    total = valorBase;
                }
                else if (categoria == "Muy alto")
                {
                    porcentaje = 10;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase + valorAjuste;
                }
            }
            else if (usuario == "comercial")
            {
                if (categoria == "Bajo")
                {
                    porcentaje = 5;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase - valorAjuste;
                }
                else if (categoria == "Medio")
                {
                    porcentaje = 0;
                    total = valorBase;
                }
                else if (categoria == "Alto")
                {
                    porcentaje = 10;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase + valorAjuste;
                }
                else if (categoria == "Muy alto")
                {
                    porcentaje = 20;
                    valorAjuste = (valorBase * porcentaje) / 100;
                    total = valorBase + valorAjuste;
                }
            }

            
                  Console.WriteLine("Nombre: " + nombre);
                  Console.WriteLine("Tipo de usuario: " + usuario);
                  Console.WriteLine("Consumo: " + consumo + " kWh");
                  Console.WriteLine("Categoría: " + categoria);
                  Console.WriteLine("Valor por kWh: $" + energia);
                  Console.WriteLine("Valor base: $" + valorBase);

            if (porcentaje > 0)
            {
                if (categoria == "Bajo" || categoria == "Medio")
                {
                    Console.WriteLine("Descuento aplicado: " + porcentaje + "%");
                    Console.WriteLine("Valor del descuento: $" + valorAjuste);
                }
                else
                {
                    Console.WriteLine("Recargo aplicado: " + porcentaje + "%");
                    Console.WriteLine("Valor del recargo: $" + valorAjuste);
                }
            }
            else
            {
                Console.WriteLine("Sin descuento ni recargo");
            }

            Console.WriteLine("Total a pagar: $" + total);



        }
    }
}
