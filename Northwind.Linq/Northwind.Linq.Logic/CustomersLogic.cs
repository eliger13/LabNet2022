using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Linq.Entities;

namespace Northwind.Linq.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public List<Customers> GetAllCustomers()
        {
            var query = from customer in context.Customers
                        select customer;

            return query.ToList();
        }

        public List<Customers> GetCustomerRegionWA()
        {
            var query = context.Customers.Where(c => c.Region == "WA");

            return query.ToList();
        }

        public List<string> GetCustomersName()
        {
            var query = from customer in context.Customers
                        select customer.CompanyName;

            return query.ToList();
        }

        public List<CustomerRegion> GetCustomerRegion()
        {
            var query = from customer in context.Customers
                        join order in context.Orders
                           on customer.CustomerID equals order.CustomerID
                        where customer.Region == "WA" && order.OrderDate > new DateTime(1997, 1, 1) 
                        select new CustomerRegion { Region = customer.Region, OrderDate = order.OrderDate };

            return query.ToList();
        }

        public List<Customers> GetFirstThreeCustomers()
        {
            var query = context.Customers.Where(c => c.Region == "WA").Take(3);

            return query.ToList();
        }

        public List<CustomerOrdersAssociated> GetCustomerOrdersAssociated()
        {
            var query = from customer in context.Customers
                        join order in context.Orders
                           on customer.CustomerID equals order.CustomerID into co
                        from newCustomerOrders in co.DefaultIfEmpty()
                        group newCustomerOrders by newCustomerOrders.CustomerID into customerOrders
                        select new CustomerOrdersAssociated{ customer = customerOrders.Key, ordersAssociated = customerOrders.Count() };

            return query.ToList();
        }

        public class CustomerRegion
        {
            public string Region { get; set; }
            public DateTime? OrderDate { get; set; }
        }

        public class CustomerOrdersAssociated
        {
            public string customer { get; set; }
            public int ordersAssociated { get; set; }
        }
    }
}