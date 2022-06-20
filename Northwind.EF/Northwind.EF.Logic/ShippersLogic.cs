using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.EF.Entities;
using Northwind.EF.Common.Exceptions;

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

        public Shippers GetShipper(int id)
        {
            var data = context.Shippers.Where(x => x.ShipperID == id).FirstOrDefault();
            return data;
        }
        public void Update(Shippers shipper)
        {
            var updateShipper = context.Shippers.Find(shipper.ShipperID);
            updateShipper.CompanyName = shipper.CompanyName;
            updateShipper.Phone = shipper.Phone;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                var deteteShipper = context.Shippers.Find(id);
                context.Shippers.Remove(deteteShipper);
                context.SaveChanges();
            }
            catch(System.Data.Entity.Infrastructure.DbUpdateException)
            {
                throw new DataRelatedDataBaseException("Shipper");

            }
            catch (Exception)
            {
                throw new Exception("There is an error deleting this shipper");
            }
        }
    }
}
