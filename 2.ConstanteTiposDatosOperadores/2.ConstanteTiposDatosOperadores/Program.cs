using System;

namespace _2.ConstanteTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Constantes:
            const string iva = "19%";
            string nombre = "Mateo";
            nombre = "Botero";
            //iva = "20%"; a una constante no se le puede cambiar su valor

            //2.Tipos de Datos:
            byte dato1 = 5;
            int dato2 = -777;
            ulong dato3 = 99999;
            float dato4 = 123.4f;
            double dato5 = 1234567.1234569d;
            //-Caracteres:
            char dato6 = ' ';//Almacena un solo caracter
            string dato7 = "___---((Hola Mundo))---___";
            bool dato8 = false; //true o false
            object dato9 = new object();

            //3.Operadores:
            //Numericos
            //cambio de signo
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato10: {0}, dato11: {1}, dato12: {2}, dato13: {3}", dato10, dato11, dato12, dato13);
            //-Operadores aritmeticos:
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//Producto
            float dato17 = 5.0f / 3.0f;//division
            //float dato17 =(float) 5 / 3;
            //float dato17 = 5f / 3f;
            Console.WriteLine("suma: {0}, resta: {1}, producto: {2}, division: {3}", dato14, dato15, dato16, dato17);

            //-Operadores de incremento y decremento:
            int dato18 = 1;
            dato18++;//=dato18 + 1;
            dato18--;//=dato18 - 1;
            dato18 += 3;//dato18 + 3;
            dato18 -= 2;//dato18 - 2;
            dato18 *= 5;//dato18 * 5;
            dato18 /= 3;//dato18 / 3;



        }
    }
}
