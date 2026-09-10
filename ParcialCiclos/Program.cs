using System;



namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El administrador de un parqueadero necesita un programa para procesar el registro de 12 vehículos que salieron del establecimiento durante el turno de la tarde.
              Utilizando obligatoriamente una estructura repetitiva, el programa debe solicitar los siguientes datos por cada vehículo:
              Tipo de vehículo(ingresando un código numérico: 1 para Moto, 2 para Automóvil, y 3 para Camión).
              Cantidad de horas(o fracción) que estuvo estacionado.
              Reglas de Cobro(Condicionales): El valor a pagar por cada vehículo se calcula multiplicando las horas estacionadas por la tarifa base de su categoría, aplicando además un recargo especial según corresponda:
              Moto(Código 1): Tarifa base de $3.000 por hora. Si estuvo estacionado más de 4 horas, se le aplica un descuento del 10 % sobre el valor total de su cobro.
              Automóvil(Código 2): Tarifa base de $5.000 por hora. Si estuvo estacionado más de 3 horas, paga una tarifa plana fija de $20.000 sin importar las horas adicionales.
              Camión(Código 3): Tarifa base de $10.000 por hora. Si el camión supera las 5 horas, se le cobra un recargo adicional de $15.000 por sobrecarga de espacio.
              Tareas del Programa:
              Por cada vehículo, calcular y mostrar en pantalla el valor exacto a pagar.
              Acumular el dinero total recaudado durante todo el turno por los 12 vehículos.
              Contar cuántos vehículos de cada tipo(motos, automóviles y camiones) atendió el parqueadero.
              Al finalizar el ciclo, mostrar en pantalla el reporte global: el total de dinero recaudado en la caja y cuántos vehículos hubo de cada categoría.*/




            double totalRecaudado = 0;
            int contadorMotos = 0;
            int contadorAutos = 0;
            int contadorCamiones = 0;
            double valorPagar = 0;
                


            for (int acumulador = 1; acumulador <= 12; acumulador++)
            {
                Console.WriteLine("Vehículo " + acumulador);
                Console.Write("Ingrese tipo (1=Moto, 2=Automóvil, 3=Camión):");
                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese las horas de estacionamiento:");
                int horas = int.Parse(Console.ReadLine());
                


                if (tipo == 1) 
                {
                    contadorMotos = contadorMotos + 1;
                    valorPagar = horas * 3000;

                    if (horas > 4)
                    {
                        valorPagar = valorPagar - (valorPagar * 0.10); 
                    }
                }
                else if (tipo == 2) 
                {
                    contadorAutos = contadorAutos + 1;

                    if (horas > 3)
                    {
                        valorPagar = 20000; 
                    }
                    else
                    {
                        valorPagar = horas * 5000;
                    }
                }
                else if (tipo == 3) 
                {
                    contadorCamiones = contadorCamiones + 1;
                    valorPagar = horas * 10000;

                    if (horas > 5)
                    {
                        valorPagar = valorPagar + 15000; 
                    }
                }
                else
                {
                    Console.WriteLine("Tipo de vehículo no válido.");
                }

                
                Console.WriteLine("Total a pagar por este vehículo: $" + valorPagar);
                Console.WriteLine("---------------------------------");

                totalRecaudado = totalRecaudado + valorPagar;
            }

           
            Console.WriteLine("REPORTE GLOBAL:");
            Console.WriteLine("Total recaudado: $" + totalRecaudado);
            Console.WriteLine("Cantidad de Motos: " + contadorMotos);
            Console.WriteLine("Cantidad de Automóviles: " + contadorAutos);
            Console.WriteLine("Cantidad de Camiones: " + contadorCamiones);
        }
    }
}
