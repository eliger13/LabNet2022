using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Linq.Logic;

namespace Northwind.Linq.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new CustomersLogic();
            var products = new ProductsLogic();

            //Exercise 1 - table Customer
            Console.WriteLine("Exercise 1");
            var allCustomers = customers.GetAllCustomers();
            foreach (var customer in allCustomers)
            {
                Console.WriteLine(customer.CompanyName);
            }

            //Exercise 2 - table Products
            Console.WriteLine("Exercise 2");
            var productsWithoutStock = products.GetProductsWithoutStock();
            foreach(var product in productsWithoutStock)
            {
                Console.WriteLine(product.ProductName);
            }

            //Exercise 3 - table Products
            Console.WriteLine("Exercise 3");
            var productsWithStock = products.GetProductsWithStock();
            foreach (var product in productsWithStock)
            {
                Console.WriteLine(product.ProductName);
            }

            //Exercise 4 - table Customers
            Console.WriteLine("Exercise 4");
            var customersRegionWA = customers.GetCustomerRegionWA();
            foreach (var customer in customersRegionWA)
            {
                Console.WriteLine(customer.CompanyName);
            }

            //Exercise 5 - table Products
            Console.WriteLine("Exercise 5");
            Console.WriteLine($"First Prodcuct: {products.GetProductFirst()}");

            //Exercise 6 - table Customers
            Console.WriteLine("Exercise 6");
            var customersName = customers.GetCustomersName();
            foreach (var customer in customersName)
            {
                Console.WriteLine($"UpperCase: {customer.ToUpper()} - LoweCase: {customer.ToLower()}");
            }

            //Exercise 7 - tables Customers and Orders
            Console.WriteLine("Exercise 7");
            var customerRegionAndDate = customers.GetCustomerRegion();
            foreach (var customer in customerRegionAndDate)
            {
                Console.WriteLine($"{customer.Region}, {customer.OrderDate}");
            }

            //Exercise 8 - table Customerss
            Console.WriteLine("Exercise 8");
            var firstThreeCustomers = customers.GetFirstThreeCustomers();
            foreach(var customer in firstThreeCustomers)
            {
                Console.WriteLine($"{customer.ContactName}");
            }

            //Exercise 9 - table Products
            Console.WriteLine("Exercise 9");
            var productsOrderByAsc = products.GetProductsOrdersByAsc();
            foreach (var product in productsOrderByAsc)
            {
                Console.WriteLine($"{product.ProductName}");
            }

            //Exercise 9 - table Products
            Console.WriteLine("Exercise 10");
            var productsOrderByStock = products.GetProductsOrderByStock();
            foreach (var product in productsOrderByStock)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}");
            }

            //Exercise 11 - tables Products and Categories
            Console.WriteLine("Exercise 11");
            var productsWithCategory = products.GetProductsWithCategory();
            foreach (var product in productsWithCategory)
            {
                Console.WriteLine($"Category {product.categoryName} is asociate by {product.productName}.");
            }

            //Exercise 12 - table products
            Console.WriteLine("Exercise 12");
            Console.WriteLine($" First product: {products.GetFirstProduct().ProductName}");

            //Exercise 13 - table Customers and Orders
            Console.WriteLine("Exercise 13");
            var customerOrdersAssociated = customers.GetCustomerOrdersAssociated();
            foreach (var customer in customerOrdersAssociated)
            {
                Console.WriteLine($"Customer: {customer.customer.CompanyName} has associate: {customer.ordersAssociated} orders.");
            }

            Console.ReadLine();
        }
    }
}
