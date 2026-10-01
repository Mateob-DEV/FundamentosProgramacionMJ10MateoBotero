using System;


namespace _17.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de Fundamentos de Programacion");
            MostrarMensaje("Mateo");
            MostrarMensaje("Mateo", "Botero Jimenez");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedimientos sin parametros

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parametros

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programacion");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programacion");
        }
    }
}
