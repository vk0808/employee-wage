using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1000, 100, 20);


            Console.WriteLine(employee.Greet() + "\n");

            employee.CalculateWage();

            Console.WriteLine("Total Working Hours: " + employee.GetHrs());
            Console.WriteLine("No of Working days: " + employee.GetDays());
            Console.WriteLine("Total Wage: " + employee.GetWage());
        }
    }
}