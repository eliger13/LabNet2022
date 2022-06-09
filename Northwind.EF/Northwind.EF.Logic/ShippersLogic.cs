using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EF.Entities;

namespace Northwind.EF.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Add(Shippers shipper)
        {
            context.Shippers.Add(shipper);
            context.SaveChanges();
        }
        public void Update(Shippers shipper)
        {
            var actualizarShipper = context.Shippers.Find(shipper.ShipperID);
            actualizarShipper.CompanyName = shipper.CompanyName;
            actualizarShipper.Phone = shipper.Phone;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var eliminarShipper = context.Shippers.Find(id);
            context.Shippers.Remove(eliminarShipper);
            context.SaveChanges();
        }
    }
}
