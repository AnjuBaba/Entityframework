using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Service
{
    class Employee
    {
        [Key] public int E_id { get; set; }
        [Required] public string E_name { get; set; }
        public string designation { get; set; }
        public double SALARY { get; set; }
        public int D_id { get; set; }
       public Department dept { get; set; }
      


    }

}
