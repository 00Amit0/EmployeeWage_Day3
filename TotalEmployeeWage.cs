using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class TotalEmployeeWage
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void EmployeeWageForDays()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalempWage = 0;
            for(int day = 0 ; day <= NUM_OF_WORKING_DAYS ; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                totalempWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total EmpWage :" + totalempWage);
            Console.ReadLine();
        }
        
    }
}
