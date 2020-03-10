using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_db1_CONSOLE_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities context = new EmployeeDBEntities();
                
                var employee1 = context.Employees;
            employee1.Add(new Employee { Emp_id = 1,
                Name = "anjan", salary = 5000, dept_id = 2 });


            var employee2 = context.Employees;
            employee2.Add(new Employee
            {
                Emp_id = 2,
                Name = "ajay",
                salary = 4000,
                dept_id = 1
            });

            context.SaveChanges();
           // Console.ReadKey();
        }
    }
}
