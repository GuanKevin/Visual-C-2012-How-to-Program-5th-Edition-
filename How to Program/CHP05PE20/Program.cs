using System;

/**
 * 5.20 (Salary Calculator) 
 * Develop a C# app that will determine the gross pay for each of three employees. The company pays straight time for 
 * the first 40 hours worked by each employee and time-and-a-half for all hours worked in excess of 40 hours. You’re 
 * given a list of the three employees of the company, the number of hours each employee worked last week and the hourly 
 * rate of each employee. Your app should input this information for each employee, then should determine and display 
 * the employee’s gross pay. Use the Console class’s ReadLine method to input the data.
 */
namespace CHP05PE20
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee 
                emp1 = new Employee(),
                emp2 = new Employee(45, 27),
                emp3 = new Employee(60, 15);

            Console.WriteLine("The salary of Employee 1 is {0:C}.", emp1.EmployeeSalary());
            Console.WriteLine("The salary of Employee 2 is {0:C}.", emp2.EmployeeSalary());
            Console.WriteLine("The salary of Employee 3 is {0:C}.", emp3.EmployeeSalary());
        }
    }
}
