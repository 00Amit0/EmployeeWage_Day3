using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class TotalEmployeeWageHrs
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void EmployeeWageForHrs()
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int totalworkingdays = 0;
            while (totalempHrs <= MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
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
                totalempHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingdays + "Emp Hrs:" + empHrs);
            }
            int totalempWage = totalempHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total Emp Wage :" + totalempWage);
            Console.ReadLine();
        }
    }
}
