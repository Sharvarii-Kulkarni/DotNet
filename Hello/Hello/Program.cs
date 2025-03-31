using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample List of Students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 22, Marks = 85 },
            new Student { Id = 2, Name = "Bob", Age = 21, Marks = 78 },
            new Student { Id = 3, Name = "Charlie", Age = 23, Marks = 90 },
            new Student { Id = 4, Name = "David", Age = 20, Marks = 65 }
        };

        // Query Syntax (SQL-like)
        var highScorers = from student in students
                          where student.Marks > 80
                          orderby student.Marks descending
                          select student;

        Console.WriteLine("High Scorers (Query Syntax):");
        foreach (var student in highScorers)
        {
            Console.WriteLine($"{student.Name} - Marks: {student.Marks}");
        }

        // Method Syntax (Fluent Style)
        var youngStudents = students.Where(s => s.Age < 22).OrderBy(s => s.Age).Select(s => s.Name);

        Console.WriteLine("\nYoung Students (Method Syntax):");
        foreach (var name in youngStudents)
        {
            Console.WriteLine(name);
        }
    }
}

// Student Class
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
