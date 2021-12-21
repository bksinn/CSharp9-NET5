using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Packt.Shared;

namespace WorkingWithEfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            //QueryCategories();
            FilteredIncudes();
            //QueryingProducts();
        }

        static void QueryCategories()
        {
            using (var db = new Northwind())
            {
                Console.WriteLine("Categories and how many products they have:");
                //a query to get all categories and their related products
                IQueryable<Category> cats = db.Categories
                    .Include(c => c.Products);

                foreach(Category c in cats)
                {
                    Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products");

                }
            }
        }
        
        static void FilteredIncudes()
        {
            using (var db=new Northwind())
            {
                Console.WriteLine("Enter a minimum for units in stock:");
                string unitsInStock = Console.ReadLine();
                int stock = int.Parse(unitsInStock);
                IQueryable<Category> cats = db.Categories
                    .Include(c => c.Products
                        .Where(p => p.Stock > stock)
                    );
                
                Console.WriteLine($"ToQueryString: {cats.ToQueryString()}");

                foreach(Category c in cats)
                {
                    Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products with a minimum of {stock} units in stock.");
                    foreach(Product p in c.Products)
                    {
                        Console.WriteLine($"{p.ProductName} has {p.Stock} units in stock.");

                    }
                }
            }
        }

        static void QueryingProducts()
        {
            using (var db = new Northwind())
            {
                Console.WriteLine("Products that cost more than a price, highest at top.");
                string input;
                decimal price;
                do{
                    Console.Write("Enter a product price:");
                    input = Console.ReadLine();

                } while (!decimal.TryParse(input, out price));

                IQueryable<Product> prods = db.Products
                    .Where(product => product.Cost > price)
                    .OrderByDescending(product => product.Cost);
                
                foreach (Product item in prods)
                {
                    Console.WriteLine(
                        "{0}: {1} costs {2:$#, ##0.00} and has {3} in stock.",
                        item.ProductId,
                        item.ProductName,
                        item.Cost,
                        item.Stock
                    );
                }
            }
        }
    }
}