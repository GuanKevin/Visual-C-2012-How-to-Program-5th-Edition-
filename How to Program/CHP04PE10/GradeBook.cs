using System;

class GradeBook
{
    private string courseName;
    private string instructorName;

    public GradeBook() : this("How to Program Visual C#", "Kevin G") { }

    public GradeBook(string courseName, string instructorName)
    {
        this.courseName = courseName;
        this.instructorName = instructorName;
    }

    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }

    public string InstructorName { get => instructorName; set => instructorName = value; }

    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to {0}!" +
            "\nThis course is presented by: {1}"
            , CourseName, instructorName);
    }
}