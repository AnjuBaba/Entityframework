using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // needed for DBContext

namespace Code_FIRST_EFDemoCF
{                                   
    class ProductContext :DbContext
    {
        public ProductContext() : base("ProductContext") { }
        public DbSet<Product> Products { get; set; }
    }
}
