using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.MVC.Models
{
    public class Restauraunt
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }

    public class RestaurantDbContext: DbContext
    {
        public DbSet<Restauraunt> Restaurants { get; set; }
    }

}