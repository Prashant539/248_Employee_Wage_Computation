using EmployeeWageProgram;
using System;
namespace EmployeeWgeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //Employee employee = new Employee();
            Employee.EmployeeWage("DMart", 20, 2, 10);
            Employee.EmployeeWage("Reliance", 20, 4, 10);
            Console.ReadLine();
        }
    }
}
