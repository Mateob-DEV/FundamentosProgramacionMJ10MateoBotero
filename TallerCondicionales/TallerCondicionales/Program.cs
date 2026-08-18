using System;


namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
             numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
             diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
             pantalla los números de menor a mayor.
             Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
             ingresar números diferentes. */



            float numero1 = 0;
            float numero2 = 0;
            float numero3 = 0;
            float mayor = 0;
            float medio = 0;
            float menor = 0;


            Console.Write("Ingrese el primer número: ");
            numero1=float.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2=float.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            numero3=float.Parse(Console.ReadLine());

            Console.WriteLine($"{numero1} {numero2} {numero3}");


            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Error debe ingresar numeros diferentes");
            }
            else 
            {
                if (numero1 > numero2 && numero1 > numero3)
                {
                    mayor = numero1;
                    if (numero2 > numero3)
                    {
                        medio = numero2;
                        menor = numero3;
                    }
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    mayor = numero2;
                    if (numero1 <= numero3)
                    {
                        medio = numero3;
                        menor = numero1;
                    }

                    else
                    {
                        medio = numero1;
                        menor = numero3;

                    }
                }
                else if (numero3 > numero1 && numero3 > numero2)
                        {
                                mayor = numero3;
                                if (numero2 > numero1)
                                {
                                    medio = numero2;
                                    menor = numero1;
                                }
                                
                        }
                Console.WriteLine("El numero mayor es el:" + mayor);
                Console.WriteLine("El numero medio es el:" + medio);
                Console.WriteLine("El numero menor es el:" + menor);
                
            }
                }
            }

           
            }
            


