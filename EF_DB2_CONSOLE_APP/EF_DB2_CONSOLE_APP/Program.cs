using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DB2_CONSOLE_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeeDB1Entities context = new EmployeeeDB1Entities();
            var em1 = context.EMs;
            em1.Add(new EM
            {
                emp_id = 1,
                emp_name = "anjan",
                salary = 50000

            });
            Console.ReadKey();
        }
    }
}
