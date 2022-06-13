using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Linq.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
    }
}
