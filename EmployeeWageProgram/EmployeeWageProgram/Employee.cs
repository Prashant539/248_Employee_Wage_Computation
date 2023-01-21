using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class Employee
    {
        public void EmployeeWage()
        {
            //Constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 2;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {

                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("\nFull Time Employee");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("\nPart Time Employee");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("\nEmployee is Absent");
                        break;

                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
            
            
