using System;

/**
 * 4.13 (Employee Class) 
 * Create a class called Employee that includes three pieces of information as either instance variables or 
 * automatic properties—a first name (type string), a last name (type string) and a monthly salary (decimal). 
 * Your class should have a constructor that initializes the three values. Provide a property with a get 
 * and set accessor for any instance variables. If the monthly salary is negative, the set accessor should 
 * leave the instance variable unchanged. Write a test app named EmployeeTest that demonstrates class Employee’s 
 * capabilities. Create two Employee objects and display each object’s yearly salary. Then give each Employee a 
 * 10% raise and display each Employee’s yearly salary again.
 */
namespace CHP04PE13
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee me = new Employee();
            Console.WriteLine("Employee Name: {0}, {1}", me.LastName, me.FirstName);
            Console.WriteLine("Monthly Salary is: {0:C}.", me.MonthlySalary);
            Console.WriteLine("Yearly Salary is: {0:C}.", me.YearlySalary());
            me.GiveRaise();
            Console.WriteLine("Yearly Salary after the raise is: {0:C}.\n", me.YearlySalary());

            Employee emp2 = new Employee("Michael", "G", 2500.00M);
            Console.WriteLine("Employee Name: {0}, {1}", emp2.LastName, emp2.FirstName);
            Console.WriteLine("Monthly Salary is: {0:C}.", emp2.MonthlySalary);
            Console.WriteLine("Yearly Salary is: {0:C}.", emp2.YearlySalary());
            emp2.GiveRaise();
            Console.WriteLine("Yearly Salary after the raise is: {0:C}.", emp2.YearlySalary());
        }
    }
}
