using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Exceptions
{
    public static class DivisionExeptions
    {
        //Punto 1
        public static void RealizarDivisionPorCero(this int num1)
        {
            try
            {
                int division = num1 / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Se termino de realizar la division");
            }
        }

        //Punto 2
        public static void RealizarDivisionDeDosNumeros(this int dividendo, string divisor=null)
        {
            try
            {
                int division = dividendo / int.Parse(divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
            }
        }
    }
}
