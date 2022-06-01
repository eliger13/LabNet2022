using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Exceptions;

namespace TP2
{
    public class Logic 
    {
        //Punto 3
        public void MetodoQueGeneraExcepcion()
        {
            throw new Exception("Se genero una excepcion!");
        }

        //Punto 4
        public void MetodoQueGeneraExcepcionPersonalizada()
        {
            throw new MyException("Se genero una excepcion personalizada!");
        }
    }
}
