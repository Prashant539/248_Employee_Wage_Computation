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
            employee.EmployeeWage();
        }
    }
}
