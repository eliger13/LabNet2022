using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EF.Entities;

namespace Northwind.EF.Logic
{
    public class Order_DetailsLogic : BaseLogic
    {
        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }
        public void Add(Order_Details orderDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order_Details orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
