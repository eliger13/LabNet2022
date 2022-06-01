using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Exceptions
{
    public class MyException : Exception
    {
        //Punto 4
        public MyException(string message) : base($"Excepcion Personalizada: [{message}]")
        {

        }
    }
}
