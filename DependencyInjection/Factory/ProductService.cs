﻿using DependencyInjection.InterfaceFactory;
using DependencyInjection.Model;

namespace DependencyInjection.Factory
{
    public class ProductService : IProduct
    {
        private Dictionary<string, Product> products;
        public ProductService()
        {
            products = new Dictionary<string, Product>();
            new List<Product> {
                new Product { Name = "Women Shoes", Price = 99M },
                new Product { Name = "Skirts", Price = 29.99M },
                new Product { Name = "Pants", Price = 40.5M }
            }.ForEach(p => AddProduct(p));
        }
        public IEnumerable<Product> Products => products.Values;
        public Product this[string name] => products[name];
        public void AddProduct(Product product) => products[product.Name] = product;
        public void DeleteProduct(Product product) => products.Remove(product.Name);
    }
}
