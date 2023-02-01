using EmployeeWageProgram;
using System;
namespace EmployeeWgeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee employee = new Employee();
            employee.EmployeeWage("DMart", 20, 2, 10);
            employee.EmployeeWage("Reliance", 20, 4, 10);
        }
    }
}
