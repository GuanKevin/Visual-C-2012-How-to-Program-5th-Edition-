using System;

/**
 * 4.10 (GradeBook Modification) 
 * Modify class GradeBook (Fig. 4.12) as follows:
 * a) Include a second string auto-implemented property that represents the name of the course’s instructor. 
 * b) Modify the constructor to specify two parameters—one for the course name and one for the instructor’s name. 
 * c) Modify method DisplayMessage such that it first outputs the welcome message and course name, 
 * then outputs "This course is presented by: ", followed by the instructor’s name.
 */
namespace CHP04PE10
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();
            GradeBook myGradeBook2 = new GradeBook("Introduction to Java Programming", "Kevin G");
            myGradeBook2.InstructorName = "Mozilla F. Fox";
            myGradeBook2.CourseName = "Learn Rust Programming";

            myGradeBook2.DisplayMessage();
        }
    }
}
