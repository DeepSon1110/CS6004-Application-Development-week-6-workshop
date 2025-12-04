class CashierSales
{
    public string Name { get; set; }
    public decimal Sales { get; set; }

}

class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}
 class  Song
{
    public string Title { get; set; }
    public int DurationSeconds { get; set; }
}

public class Program { 
    public static void Main()
    {  
        //operations of class Applicant
        var applicants = new List<Applicant>
        {
            new Applicant { Name = "Alice", Age = 30 },
            new Applicant { Name = "Bob", Age = 22 },
            new Applicant { Name = "Charlie", Age = 28 }
        };
        bool allAbove16 = applicants.All(a => a.Age > 16);

        bool anyUnder18 = applicants.Any(a => a.Age < 18);

        Console.WriteLine(" Election Commission checks ");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"Are all applicants above 16? {allAbove16}");

        //operations of class CashierSales
        var cashierSales = new List<CashierSales>
        {
            new CashierSales { Name = "sandy", Sales = 1500.50m },
            new CashierSales { Name = "pratish", Sales = 2500.75m },
            new CashierSales { Name = "Martin Guptill", Sales = 1800.00m }
        };
        decimal highestSales = cashierSales.Max(c => c.Sales);

        decimal lowestSales = cashierSales.Min(c => c.Sales);

        decimal averageSales = cashierSales.Average(c => c.Sales);

        Console.WriteLine("\n Cashier Sales Analysis ");
        Console.WriteLine($"Highest Sales: {highestSales}");
        Console.WriteLine($"Lowest Sales: {lowestSales}");
        Console.WriteLine($"Average Sales: {averageSales}");

        //operations of class Song
        var songs = new List<Song>
        {
            new Song { Title = "Song A", DurationSeconds = 210 },
            new Song { Title = "Song B", DurationSeconds = 700 },
            new Song { Title = "Song C", DurationSeconds = 500 }
        };

        Song first = songs.First();
        Song last = songs.Last();

        Song firstover4min = songs.First(s => s.DurationSeconds > 4 * 60);
        Song lastunder3min = songs.FirstOrDefault(s => s.DurationSeconds > 10 * 60);

        Console.WriteLine("\n Song Duration Analysis ");
        Console.WriteLine($"First Song: {first.Title}, Duration: {first.DurationSeconds} seconds");
        Console.WriteLine($"Last Song: {last.Title}, Duration: {last.DurationSeconds} seconds");
        Console.WriteLine($"First Song over 4 minutes: {(firstover4min != null ? firstover4min.Title : "None")}");
        Console.WriteLine($"First Song over 10 minutes: {(lastunder3min != null ? lastunder3min.Title : "None")}");


    }
}



