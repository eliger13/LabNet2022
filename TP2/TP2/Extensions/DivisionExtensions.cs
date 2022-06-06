using System;

namespace TP2.Extensions
{
    public static class DivisionExtensions
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
                throw new Exception("No se puede dividir por cero.");
            }
        }

        //Punto 2
        public static float RealizarDivisionDeDosNumeros(this int dividendo, string divisor=null)
        {
            try
            {
                int division = dividendo / int.Parse(divisor);
                return division;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception ("Solo Chuck Norris divide por cero!");
            }
            catch (Exception ex)
            {
                throw new Exception ("Seguro ingreso una letra o no ingreso nada!");
            }
        }
    }
}
