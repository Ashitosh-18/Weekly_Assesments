using System;

class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    public string Course { get; set; }
}
/*
class Program
{
    static void Main()
    {
        Student student = new Student { Name = "John", Course = "Computer Science" };

        // Upcasting
        Person person = student;
        Console.WriteLine($"Upcasting: {person.Name}");

        // Downcasting
        Student downcastedStudent = (Student)person;
        Console.WriteLine($"Downcasting: {downcastedStudent.Course}");

        Console.ReadLine();
    }
}
*/
