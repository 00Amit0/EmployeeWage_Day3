using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmpWage_MultiCompanies
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        public static int ComputeEmpWage_MultiComp(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int totalworkingdays = 0;
            while (totalempHrs <= maxHoursPerMonth && totalworkingdays < numOfWorkingDays)
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
            int totalEmpWage = totalempHrs * empRatePerHr;
            Console.WriteLine("Total Emp Wage for company : " + company + "is : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
