using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.EF.Common.Exceptions;
using Northwind.EF.Entities;

namespace Northwind.EF.Logic
{
    public class Order_DetailsLogic : BaseLogic
    {
        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }

        public void Update(Order_Details orderDetail)
        {
            var updateOrderDetail = context.Order_Details.Find(orderDetail.OrderID, orderDetail.ProductID);
            updateOrderDetail.UnitPrice = orderDetail.UnitPrice;
            updateOrderDetail.Quantity = orderDetail.Quantity;
            updateOrderDetail.Discount = orderDetail.Discount;
            context.SaveChanges();
        }
        public void Delete(int ordId, int prdId)
        {
            try
            {
                var deleteOrderDetail = context.Order_Details.Find(ordId, prdId);
                context.Order_Details.Remove(deleteOrderDetail);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                throw new DataRelatedDataBaseException("Order");

            }
            catch (Exception)
            {
                throw new Exception("There is an error deleting this order.");
            }
        }
    }
}
