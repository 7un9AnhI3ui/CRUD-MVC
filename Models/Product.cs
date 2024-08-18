using System;
//using crud.Data;
//using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    /*public class ProductContext: ApplicationDbContext
    {
        public ProductContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }*/

    public class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Color { get; set; }
        public string? Type{ get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}

