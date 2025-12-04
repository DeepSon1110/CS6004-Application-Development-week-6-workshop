public class TourBooking {
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }

}

public class Program {
    public static void Main()
    {
        var bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Sandy", Destination = "Paris", Price = 120033, DurationInDay = 7, IsInternational = true },
            new TourBooking { CustomerName = "Martin", Destination = "Kathmandu", Price = 166676, DurationInDay = 4, IsInternational = false },
            new TourBooking { CustomerName = "Faf du faf", Destination = "Pokhara", Price = 20202, DurationInDay = 12, IsInternational = false },
            new TourBooking { CustomerName = "Pratish", Destination = "Itahari", Price = 16000, DurationInDay = 9, IsInternational = false },
            new TourBooking { CustomerName = "Narayan JOshi", Destination = "Dubai", Price = 180000, DurationInDay = 10, IsInternational = true },
            new TourBooking { CustomerName = "Basir ", Destination = "London", Price = 129990, DurationInDay = 14, IsInternational = true },
            new TourBooking { CustomerName = "Binod", Destination = "Biratnagar", Price = 1565656, DurationInDay = 8, IsInternational = true }
        };

        var filterTours = bookings
            .Where(t => t.Price > 10000 && t.DurationInDay > 4);

        var projected = filterTours
        .Select(t => new
        {
        t.CustomerName,
        t.Destination,
        Category = t.IsInternational ? "International" : "Domestic",
        t.Price
        });

         var sortedResult = projected
        .OrderBy(t => t.Category)  
        .ThenBy(t => t.Price);

        Console.WriteLine("Travel Company Market Analysis Report\n");

        foreach (var t in sortedResult)
        {
            Console.WriteLine($"Customer Name : {t.CustomerName}");
            Console.WriteLine($"Destination   : {t.Destination}");
            Console.WriteLine($"Category      : {t.Category}");
            Console.WriteLine($"Price         : Rs. {t.Price}\n");
            
        }
    }
}

    



