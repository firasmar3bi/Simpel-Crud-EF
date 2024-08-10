using CrudTaskTwo.Models;
using CrudTaskTwo.Data;

namespace CrudTaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            // Add Products =>
            // Product product = new Product() { Name = "IPhone", Price = 4500 };
            //dbContext.Add(product);
            //dbContext.SaveChanges();

            // Add Order =>
            // Order order = new Order() { Adress = "jenin" };
            // dbContext.Add(order);
            // dbContext.SaveChanges();

            // Get Producrs =>
            var Products = dbContext.products.ToList();
            foreach(var pro in Products)
            {
                Console.WriteLine($"{pro.Name}");
            }

            // Get Order =>
            var Order = dbContext.orders.ToList();
            foreach (var ord in Order)
            {
                Console.WriteLine($"{ord.Adress}");
            }

            //Update Product =>
            //var ProductId = dbContext.products.First(Product => Product.Id == 1);
            //ProductId.Name = "Nablus";
            //dbContext.SaveChanges();


            //Update Order =>
            //var OrderId = dbContext.orders.First(order => order.Id == 1);
            //OrderId.Adress = "Nablus";
            //dbContext.SaveChanges();

            //remove Product =>
            //var ProductId = dbContext.products.First(Product => Product.Id == 1);
            //dbContext.products.Remove(ProductId);
            //dbContext.SaveChanges();


            //remove Order =>
            //var OrderId = dbContext.orders.First(order => order.Id == 1);
            //dbContext.orders.Remove(OrderId);
            //dbContext.SaveChanges();


            Console.WriteLine($"Done");
        }
    }
}