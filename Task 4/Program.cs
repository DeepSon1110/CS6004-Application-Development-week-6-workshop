class Program
{
    public static void Main(String[] args)
    {
        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
        var squaredNumbers = numbers.Select(n => n * n);

        Console.WriteLine("Squared Numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        List<Book> books = new List<Book>
        {
            new Book("C# Programming", 1200),
            new Book("Introduction to Algorithms", 550),
            new Book("Design Patterns", 3990)
        };
        var expensiveBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("Expensive Books:");
        foreach (var book in expensiveBooks)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine();

        List<Student> students = new List<Student>
        {
            new Student("sandy", 1),
            new Student("faf du faf", 2),
            new Student("martin guptill", 3)
        };
        var sortedStudents = students.OrderBy(s => s.Name);
        Console.WriteLine("Sorted Students:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();    
        

    }
}
public class Book
{
    public string Title { get; set; }
    public decimal Price { get; set; }

    public Book(string title, decimal price)
    {
        Title = title;
        Price = price;
    }
    public override string ToString()
    {
        return $"{Title} - Rs.{Price}";
    }
}

public class  Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }

    public
        Student(string name, int rollNumber)
    {
        Name = name;
        RollNumber = rollNumber;
    }

    public override string ToString()
    {
        return $"{Name} - Roll No: {RollNumber}";
    }

}