using System;

/**
 * 4.14 (Date Class) 
 * Create a class called Date that includes three pieces of information as automatic properties—a month (type int), 
 * a day (type int) and a year (type int). Your class should have a constructor that initializes the three automatic 
 * properties and assumes that the values provided are correct. Provide a method DisplayDate that displays the month, 
 * day and year separated by forward slashes (/). Write a test app named DateTest that demonstrates class Date’s 
 * capabilities.
 */
namespace CHP04PE14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Date().DisplayDate());
        }
    }
}
