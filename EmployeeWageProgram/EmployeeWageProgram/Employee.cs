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
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("\nFull Time Employee");
            }
            else if(empCheck == IS_PART_TIME) 
            {
                empHrs = 4;
                Console.WriteLine("\nPart Time Employee");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("\nEmployee is Absent");
            }
             
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
       
    }
}
