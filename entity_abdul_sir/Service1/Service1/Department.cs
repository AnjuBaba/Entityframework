using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Service1
{
    class Department
    {
        [Key] public int D_id { get; set; }
        [Required] public string D_name { get; set; }
        public string location { get; set; }

    }
}
