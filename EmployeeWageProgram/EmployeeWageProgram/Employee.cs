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
        
        public void EmployeeWage(string company, int empRatePerHour, int numOfWorking, int maxHoursPerMonth)
        {
       
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorking) 
            {

                totalWorkingDays++;
                Random random = new Random();
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
                totalEmpHrs = totalEmpHrs + empHrs;

                Console.WriteLine("Day: "  + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage : "  + totalEmpWage);
           
            Console.ReadLine();
        }
    }
}
            
            
