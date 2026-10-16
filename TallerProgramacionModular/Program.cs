using System;
using System.Collections.Generic;

namespace TallerProgramacionModular
{
    internal class Program
    {

        //1------------------------------------------------------------------------
        /*static void Main(string[] args)
        {
            string palabra = CapturarPalabra();


            char[] vectorCaracteres = ConvertirAVector(palabra);

            int cantidadVocales = ContarVocales(vectorCaracteres);
            int cantidadConsonantes = ContarConsonantes(vectorCaracteres);

            Console.WriteLine($"\n--- RESULTADOS ---");
            Console.WriteLine($"Palabra ingresada: {palabra}");
            Console.WriteLine($"Cantidad de vocales: {cantidadVocales}");
            Console.WriteLine($"Cantidad de consonantes: {cantidadConsonantes}");

            Console.ReadKey();
        }

        static string CapturarPalabra()
        {
            Console.WriteLine("Ingrese una palabra:");
            return Console.ReadLine();
        }

        static char[] ConvertirAVector(string palabra)
        {
            return palabra.ToCharArray();
        }

        static bool EsVocal(char c)
        {
            char caracter = char.ToLower(c);
            return caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u';
        }

        static int ContarVocales(char[] vector)
        {
            int contador = 0;
            foreach (char c in vector)
            {
                if (char.IsLetter(c) && EsVocal(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarConsonantes(char[] vector)
        {
            int contador = 0;
            foreach (char c in vector)
            {
                if (char.IsLetter(c) && !EsVocal(c))
                {
                    contador++;
                }
            }
            return contador;
        }*/


        //2------------------------------------------------------------------------------------------


        /*static void Main(string[] args)
        {
            List<string> listaTareas = new List<string>();
            int opcion;

            do
            {
                MostrarMenu();
                opcion = CapturarOpcion();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        AgregarTarea(listaTareas);
                        break;
                    case 2:
                        EliminarTarea(listaTareas);
                        break;
                    case 3:
                        MostrarTareas(listaTareas);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("========== GESTOR DE TAREAS ==========");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Mostrar lista de tareas");
            Console.WriteLine("0. Salir");
            Console.WriteLine("======================================");
            Console.Write("Ingrese una opción: ");
        }

        static int CapturarOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        static void AgregarTarea(List<string> tareas)
        {
            Console.WriteLine("--- AGREGAR TAREA ---");
            Console.Write("Ingrese la descripción de la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nuevaTarea))
            {
                tareas.Add(nuevaTarea);
                Console.WriteLine("¡Tarea agregada con éxito!");
            }
            else
            {
                Console.WriteLine("No se puede agregar una tarea vacía.");
            }
        }

        static void MostrarTareas(List<string> tareas)
        {
            Console.WriteLine("--- LISTA DE TAREAS ---");
            if (tareas.Count == 0)
            {
                Console.WriteLine("La lista de tareas está vacía.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }

        static void EliminarTarea(List<string> tareas)
        {
            Console.WriteLine("--- ELIMINAR TAREA ---");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
                return;
            }

            MostrarTareas(tareas);
            Console.Write("\nIngrese el número de la tarea que desea eliminar: ");
            int numero = CapturarOpcion();

            if (numero >= 1 && numero <= tareas.Count)
            {
                string tareaEliminada = tareas[numero - 1];
                tareas.RemoveAt(numero - 1);
                Console.WriteLine($"¡Tarea '{tareaEliminada}' eliminada con éxito!");
            }
            else
            {
                Console.WriteLine("Número de tarea no válido.");
            }
        }*/

        //3------------------------------------------------------------------------------------
       /* static void Main(string[] args)
        {
            int opcionCategoria;

            do
            {
                MostrarMenuPrincipal();
                opcionCategoria = CapturarOpcion();
                Console.Clear();

                switch (opcionCategoria)
                {
                    case 1:
                        ProcesarMasa();
                        break;
                    case 2:
                        ProcesarCapacidad();
                        break;
                    case 3:
                        ProcesarLongitud();
                        break;
                    case 4:
                        ProcesarTiempo();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del conversor...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcionCategoria != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcionCategoria != 0);
        }

        

        static void MostrarMenuPrincipal()
        {
            Console.WriteLine("========== CONVERSOR DE UNIDADES ==========");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Capacidad");
            Console.WriteLine("3. Longitud");
            Console.WriteLine("4. Tiempo");
            Console.WriteLine("0. Salir");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una categoría de medida: ");
        }

        static int CapturarOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return opcion;
        }

        static double PedirValor(string unidadOrigen)
        {
            Console.Write($"Ingrese la cantidad en {unidadOrigen}: ");
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Por favor, ingrese un número válido: ");
            }
            return valor;
        }

        static void MostrarResultado(double valorOrigen, string unidadOrigen, double valorDestino, string unidadDestino)
        {
            Console.WriteLine($"\n--> RESULTADO: {valorOrigen} {unidadOrigen} son {valorDestino} {unidadDestino}");
        }

        

        static void ProcesarMasa()
        {
            Console.WriteLine("--- CONVERSIÓN DE MASA ---");
            Console.WriteLine("1. De Kilogramos a Gramos");
            Console.WriteLine("2. De Gramos a Kilogramos");
            Console.Write("Seleccione una opción: ");
            int opcion = CapturarOpcion();

            if (opcion == 1)
            {
                double kg = PedirValor("Kilogramos");
                double g = kg * 1000;
                MostrarResultado(kg, "Kilogramos", g, "Gramos");
            }
            else if (opcion == 2)
            {
                double g = PedirValor("Gramos");
                double kg = g / 1000;
                MostrarResultado(g, "Gramos", kg, "Kilogramos");
            }
            else
            {
                Console.WriteLine("Subopción no válida.");
            }
        }

        static void ProcesarCapacidad()
        {
            Console.WriteLine("--- CONVERSIÓN DE CAPACIDAD ---");
            Console.WriteLine("1. De Litros a Mililitros");
            Console.WriteLine("2. De Mililitros a Litros");
            Console.Write("Seleccione una opción: ");
            int opcion = CapturarOpcion();

            if (opcion == 1)
            {
                double l = PedirValor("Litros");
                double ml = l * 1000;
                MostrarResultado(l, "Litros", ml, "Mililitros");
            }
            else if (opcion == 2)
            {
                double ml = PedirValor("Mililitros");
                double l = ml / 1000;
                MostrarResultado(ml, "Mililitros", l, "Litros");
            }
            else
            {
                Console.WriteLine("Subopción no válida.");
            }
        }

        static void ProcesarLongitud()
        {
            Console.WriteLine("--- CONVERSIÓN DE LONGITUD ---");
            Console.WriteLine("1. De Kilómetros a Metros");
            Console.WriteLine("2. De Metros a Kilómetros");
            Console.Write("Seleccione una opción: ");
            int opcion = CapturarOpcion();

            if (opcion == 1)
            {
                double km = PedirValor("Kilómetros");
                double m = km * 1000;
                MostrarResultado(km, "Kilómetros", m, "Metros");
            }
            else if (opcion == 2)
            {
                double m = PedirValor("Metros");
                double km = m / 1000;
                MostrarResultado(m, "Metros", km, "Kilómetros");
            }
            else
            {
                Console.WriteLine("Subopción no válida.");
            }
        }

        static void ProcesarTiempo()
        {
            Console.WriteLine("--- CONVERSIÓN DE TIEMPO ---");
            Console.WriteLine("1. De Horas a Segundos");
            Console.WriteLine("2. De Segundos a Horas");
            Console.Write("Seleccione una opción: ");
            int opcion = CapturarOpcion();

            if (opcion == 1)
            {
                double h = PedirValor("Horas");
                double s = h * 3600;
                MostrarResultado(h, "Horas", s, "Segundos");
            }
            else if (opcion == 2)
            {
                double s = PedirValor("Segundos");
                double h = s / 3600;
                MostrarResultado(s, "Segundos", h, "Horas");
            }
            else
            {
                Console.WriteLine("Subopción no válida.");
            }
        }*/
    }
}




