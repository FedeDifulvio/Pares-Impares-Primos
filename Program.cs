using System;
using System.Collections.Generic;

namespace ListasPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaNumeros = new List<int>();
            int numero = 1; 

            Console.WriteLine("Ingrese los números que desee y le informaremos cuales son PARES, IMPARES y PRIMOS. ");
            Console.WriteLine("Cuando quiera finalizar el ingreso de datos, presione cero");  

            while(numero != 0)
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    ListaNumeros.Add(numero);
                }   
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: debe ingresar un número entero");
                   
                }
                
            }
            ListaNumeros.Remove(0); 
            Console.Clear();

           
            Console.WriteLine("LISTADO DE NÚMEROS PARES: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarPares(ListaNumeros);
            Console.ResetColor();

            Console.WriteLine("LISTADO DE NÚMEROS IMPARES: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            MostrarImpares(ListaNumeros);
            Console.ResetColor();

            Console.WriteLine("LISTADO DE NÚMEROS PRIMOS: " );
            Console.ForegroundColor = ConsoleColor.Magenta;
            MostrarPrimos(ListaNumeros);
            Console.ResetColor(); 




        }

        static bool EsPar(int num)
        {
            if (num % 2 == 0) return true;
            else return false; 
        }

        static bool EsImpar(int num)
        {
            if (num % 2 == 0) return false;
            else return true;
        }

        static bool EsPrimo(int num)
        {
            int contador = 0; 
            for( int x=1; x<=num; x++)
            {
                if (num % x == 0)
                {
                    contador++; 
                }
            }
            if (contador == 2) return true;
            else return false; 
            
        } 

        static void MostrarPrimos(List<int> numeros)
        {
            Predicate<int> buscador = new Predicate<int>(EsPrimo);

            List<int> NumerosPrimos = numeros.FindAll(buscador);      /* El predicado BUSCADOR le va a indicar a FindAll todos los primos en la lista numeros*/
                                                                      /* Todos esos primos se almacenan en una nueva lista de primos. */
            MostrarLista(NumerosPrimos); 
        } 

        static void MostrarPares(List<int> numeros)
        {
            Predicate<int> buscador = new Predicate<int>(EsPar);

            List<int> NumerosPares = numeros.FindAll(buscador);

            MostrarLista(NumerosPares);

        }

        static void MostrarImpares(List<int> numeros)
        {
            Predicate<int> buscador = new Predicate<int>(EsImpar);
            List<int> NumerosImpares = numeros.FindAll(buscador);

            MostrarLista(NumerosImpares); 
        } 

        static void MostrarLista(List<int> Lista)
        {
            foreach (int number in Lista)
            {
                Console.WriteLine(number);
            }

        }
    }
}
