using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.EF.MVC.Models
{
    public class OrderDetailView
    {
        public int Id { get; set; }

        public int PrdId { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
    }

    public class OrderDetailViewPaginated
    {
        public int OrdersPerPage { get; set; }

        public int CurrentPage { get; set; }

        public IEnumerable<OrderDetailView> OrderDetails { get; set; }

        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(OrderDetails.Count() / (double)OrdersPerPage));
        }

        public IEnumerable<OrderDetailView> PaginatedOrders()
        {
            int start = (CurrentPage - 1) * OrdersPerPage;
            return OrderDetails.OrderBy(o => o.Id).Skip(start).Take(OrdersPerPage);
        }
    }
}