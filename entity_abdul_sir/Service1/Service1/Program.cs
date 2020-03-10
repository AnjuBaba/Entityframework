using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    class Program
    {
        static void Main(string[] args)
        {
            insertDEPART();
            insertemployee();
         
          
            showemp();
            showDEPART();
            Console.ReadKey();
        }

        public static void insertemployee()
        {
            Context cts = new Context();
            Console.WriteLine("enter employee ID");
            int ID1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name of employee");
            string ename = Console.ReadLine();
            Console.WriteLine("enter the designation");
            string desg = Console.ReadLine();
            Console.WriteLine("enter the salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the department id ");
            int did = Convert.ToInt32(Console.ReadLine());

            Employee em = new Employee { E_id = ID1, E_name = ename, designation = desg, SALARY = sal, D_id = did };
            cts.Employees.Add(em);
            cts.SaveChanges();
            //Console.ReadKey();

        }
        public static void showemp()
        {
            //int id = 0;
            Context cdx = new Context();
            var Employees = cdx.Employees;
            foreach (var prd in Employees)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t{3}\t {4}",prd.E_id, prd.E_name, prd.designation, prd.SALARY, prd.D_id);
            }

        }
        public static void insertDEPART()
        {
            Context cts = new Context();
            Console.WriteLine("enter department  ID");
            int ID2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name of Department");
            string dname = Console.ReadLine();
            Console.WriteLine("enter the location of Department");
            string dloc = Console.ReadLine();

            Department dm = new Department { D_id = ID2, D_name = dname, location = dloc };
            cts.Departments.Add(dm);
            cts.SaveChanges();
           // Console.ReadKey();

        }
        public static void showDEPART()
        {
            // int id = 0;
            Context cdx = new Context();
            var Departments = cdx.Departments;
            foreach (var prd in Departments)
            {
                Console.WriteLine("{0} \t {1} \t {2}", prd.D_id,prd.D_name, prd.location);
            }

        }

    }
}
