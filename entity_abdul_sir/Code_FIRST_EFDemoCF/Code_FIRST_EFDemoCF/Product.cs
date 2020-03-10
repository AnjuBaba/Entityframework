using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// needed for key attribute 

namespace Code_FIRST_EFDemoCF
{
    class Product
    {
        [Key] public int Pid { get; set; }
        [Required] public string Ptitle { get; set; }
        public double Price { get; set; }
    }
}
