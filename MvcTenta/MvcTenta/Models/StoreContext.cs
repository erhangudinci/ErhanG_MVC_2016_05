using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTenta.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("Shop")
        {
            Database.SetInitializer(new StoreInitializ());
        }
    }

    internal class StoreInitializ : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var store = new List<Store>
            {
                new Store
                {
                    StoreId = 1,
                    Name = "Hm",
                    Address = "Grönkullagatan 3",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            StoreId = 1,
                            Name = "Kavaj",
                            ProductId = 1,
                            Price = 4.33M,
                            ProductText = "En bra kavaj",
                            ProductInStock = 33,
                            ProductNumber = "p-111",
                        },
                        new Product
                        {
                            StoreId = 1,
                            Name = "Byxor",
                            ProductId = 2,
                            Price = 2.33M,
                            ProductText = "Bra byxor",
                            ProductInStock = 31,
                            ProductNumber = "p-112",
                        }
                    }
                },
                new Store
                {
                    StoreId = 2,
                    Name = "Öl",
                    Address = "Grönkullagatan 4",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            StoreId = 2,
                            Name = "Tuborg",
                            ProductId = 3,
                            Price = 1.33M,
                            ProductText = "En bra Öl",
                            ProductInStock = 222,
                            ProductNumber = "p-131",
                        },
                        new Product
                        {
                            StoreId = 2,
                            Name = "Bellman",
                            ProductId = 4,
                            Price = 1.33M,
                            ProductText = "Bra Öl",
                            ProductInStock = 31,
                            ProductNumber = "p-1133",
                        }
                    }
                }
            };
            foreach (var store1 in store)
            {
                context.Stores.Add(store1);
            }
            context.SaveChanges();
        }
    }
}