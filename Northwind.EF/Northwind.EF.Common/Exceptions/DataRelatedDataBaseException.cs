using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EF.Common.Exceptions
{
    public class DataRelatedDataBaseException : Exception
    {
        public DataRelatedDataBaseException(string message) : base($"It's not possible to delete the selected {message} because has a related data.")
        {

        }
    }
}
