using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class Employee
    {
        //Constants
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;
        public void EmployeeWage()
        {
            
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS) 
            {

                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                
                Console.WriteLine("Day: "  + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : "  + totalEmpWage);
            Console.ReadLine();
        }
    }
}
            
            
