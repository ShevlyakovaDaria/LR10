using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Count { get; set; }

        public float Price { get; set; }
    }

    public static class OrderData
    {
        public static List<Order> Items = new List<Order>();
    }

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)

            : base(options)
        {
        }

     public Microsoft.EntityFrameworkCore.DbSet<Order> Goods { get; set; }
    }
}
