using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_FIRST_EFDemoCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Instertdata();
            showdata();
          //  Console.WriteLine("");

        }
        public static void Instertdata()
        {
            ProductContext pcx = new ProductContext();  
            //  Console.WriteLine("enter Product id");   
            // int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter pname of product");
            string pname = Console.ReadLine();
            Console.WriteLine("enter price of product");
            double price = Convert.ToDouble(Console.ReadLine());
            // Product prd = new Product { Pid = pid, ,Ptitle = pname, Price = price };
            Console.WriteLine("enter pname of product");
            Product prd = new Product { Ptitle = pname, Price = price };
            pcx.Products.Add(prd);
            pcx.SaveChanges();
            Console.ReadKey();
        }
        public static void showdata()
        {
            int id = 0;
            ProductContext pdx = new ProductContext();
            var products = pdx.Products;
            //var prd = from pd in products
            //          where pd == id
            //          select pd;
            foreach (var prd in products)
            {
                Console.WriteLine("{0} \t {1} \t {2} ", prd.Pid, prd.Ptitle, prd.Price);
            }

        }
    }
}

