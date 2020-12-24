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
                    Console.WriteLine("ERROR: debe ingresar un número");
                   
                }
                
            }
            ListaNumeros.RemoveAt(ListaNumeros.Count - 1 ); 

            Console.WriteLine("Fin INGRESO");  

            foreach( int number in ListaNumeros)
            {
                Console.WriteLine(number); 
            }


        }
    }
}
