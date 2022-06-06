using System;
using TP2.Exceptions;
using TP2.Extensions;


namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 1
            try
            {
                Console.WriteLine("Punto 1");
                Console.WriteLine("Añadir dividendo:");
                int dividendo = int.Parse(Console.ReadLine());
                dividendo.RealizarDivisionPorCero();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Se termino de realizar la division.");
            }

            //punto 2
            try
            {
                Console.WriteLine("\nPunto 2");
                Console.WriteLine("Añadir dividendo:");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Añadir divisor:");
                string divisor = Console.ReadLine();
                float division = dividendo.RealizarDivisionDeDosNumeros(divisor);
                Console.WriteLine($"El resultado de la division es: {division}");
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Punto 3
            Logic l = new Logic();
            try
            {
                Console.WriteLine("\nPunto 3");
                l.MetodoQueGeneraExcepcion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }

            //Punto 4
            try
            {
                Console.WriteLine("\nPunto 4");
                l.MetodoQueGeneraExcepcionPersonalizada();
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
