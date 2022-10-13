using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class WagesForMonth
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public void CalculateWages()
        {


            int empHrs = 0;
            int empWage = 0;
            int toatEmpHrs = 0;
            int toatlempWage = 0;

            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {

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

                Console.WriteLine("Day{0} -> {1}Hours worked.", i, empHrs);
                toatEmpHrs += empHrs;
            }

            toatlempWage = toatEmpHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Total EmpWage : " + toatlempWage);
        }
    }
}
