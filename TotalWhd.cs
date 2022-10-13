using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class TotalWhd
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_HOURS = 100;

        public void CalculateTot()
        {


            int empHrs = 0;
            int totalEmpHrs = 0;
            int toatlempWage = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs < NUM_OF_WORKING_HOURS && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                Console.WriteLine("Day{0} -> {1}Hours worked.", totalWorkingDays, empHrs);
                totalEmpHrs += empHrs;
            }

            toatlempWage = totalEmpHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Total Emp Hours : " + totalEmpHrs);
            Console.WriteLine("Total EmpWage : " + toatlempWage);
        }
    }
}