using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeWage
    {
        public static void EmployeeRatePerHr()
        {

            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hr = 20;
            int empwage = 0;
            int emphrs = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
                emphrs = 8;
                
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                emphrs = 0;
            }
            empwage = emphrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage :" + empwage);
            Console.ReadKey();
        }
    }
}
