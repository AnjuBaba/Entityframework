using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data;

namespace ENTITY_FRAMEWORK_CODE_FIRST
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class  ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductDbContext")
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
    public class Product
        {
        
        public int ID { get; set; }
        public string product_name { get; set; }
        public double product_price { get; set; }
        }
}

