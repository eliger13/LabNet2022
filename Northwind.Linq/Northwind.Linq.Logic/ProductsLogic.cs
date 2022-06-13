using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Linq.Entities;

namespace Northwind.Linq.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Products> GetProductsWithoutStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0);

            return query.ToList();
        }

        public List<Products> GetProductsWithStock()
        {
            var query = from product in context.Products
                        where product.UnitsInStock != 0 && product.UnitPrice > 3
                        select product;

            return query.ToList();
        }

        public Products GetProductFirst()
        {
            var query = context.Products.Where(p => p.ProductID == 789);

            return query.FirstOrDefault();
        }

        public List<Products> GetProductsOrdersByAsc()
        {
            var query = from product in context.Products 
                        orderby product.ProductName ascending
                        select product;

            return query.ToList();
        }

        public List<Products> GetProductsOrderByStock()
        {
            var query = context.Products.OrderBy(p => p.UnitsInStock);

            return query.ToList();
        }

        public List<ProductsCategories> GetProductsWithCategory()
        {
            var query = from product in context.Products
                        join category in context.Categories
                           on product.CategoryID equals category.CategoryID
                        select new ProductsCategories { productName = product.ProductName, categoryName = category.CategoryName };

            return query.ToList();
        }

        public Products GetFirstProduct()
        {
            var query = context.Products.Select(p => p).ToList();

            return query.First();
        }

        public class ProductsCategories
        {
            public string productName;
            public string categoryName;
        }
    }
}
