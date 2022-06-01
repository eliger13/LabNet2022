using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Exceptions;

namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añadir dividendo:");
            int dividendo = int.Parse(Console.ReadLine());
            dividendo.RealizarDivisionPorCero();
            Console.WriteLine("Añadir divisor:");
            string divisor = Console.ReadLine();
            dividendo.RealizarDivisionDeDosNumeros(divisor);
            dividendo.RealizarDivisionDeDosNumeros(null);
            dividendo.RealizarDivisionDeDosNumeros("0");

            //Punto 3
            Logic l = new Logic();
            try
            {
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
