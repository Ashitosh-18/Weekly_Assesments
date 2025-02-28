using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book() // Default constructor
    {
        Title = "Unknown";
        Author = "Unknown";
        ISBN = "0000";
    }

    public Book(string title, string author) // Constructor with title and author
    {
        Title = title;
        Author = author;
    }

    public Book(string title, string author, string isbn) // Constructor with all properties
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}
/*
class Program
{
    static void Main()
    {
        Book book1 = new Book();
        Book book2 = new Book("C# Basics", "John Doe");
        Book book3 = new Book("Advanced C#", "Jane Doe", "1234567890");

        Console.WriteLine($"Book 1: {book1.Title}, {book1.Author}, {book1.ISBN}");
        Console.WriteLine($"Book 2: {book2.Title}, {book2.Author}");
        Console.WriteLine($"Book 3: {book3.Title}, {book3.Author}, {book3.ISBN}");

        Console.ReadLine();
    }
}
*/
