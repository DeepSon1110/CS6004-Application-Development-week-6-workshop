public  delegate int Calculate(int x, int y);
public delegate double DiscountStrategy(double price);
public class Program
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    public static double FestivalDiscount(double price) => price - (price * 0.2);

    public static double SeasonalDiscount(double price) => price - (price * 0.1);

    public static double NoDiscount(double price) => price;


    public static void Main()
    {
        Calculate cal = Add;
        Console.WriteLine("Addition: " + cal(10, 5));

        Calculate cal2 = Subtract;
        Console.WriteLine("Subtraction: " + cal2(10, 5));

        DiscountStrategy discount = FestivalDiscount;
        Console.WriteLine("Price after Festival Discount on Rs. 100: Rs." + discount(100));

        DiscountStrategy discount2 = SeasonalDiscount;
        Console.WriteLine("Price after Seasonal Discount on RS. 100: Rs. " + discount2(100));

        DiscountStrategy discount3 = NoDiscount;
        Console.WriteLine("No Discount on Rs.100: Rs." + discount3(100));


    }
}

