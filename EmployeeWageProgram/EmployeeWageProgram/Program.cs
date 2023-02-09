using EmployeeWageProgram;
using System;
namespace EmployeeWgeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee Dmart = new Employee("Dmart", 20, 2, 10);
            Employee Reliance = new Employee("Reliance", 20, 4, 10);
            Dmart.computeEmpWage();
            Console.WriteLine(Dmart.toString());
            Reliance.computeEmpWage();
            Console.WriteLine(Reliance.toString());
        }
    }
}
