using Northwind.Linq.Data;

namespace Northwind.Linq.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindLinqContext context;

        public BaseLogic()
        {
            context = new NorthwindLinqContext();
        }
    }
}
