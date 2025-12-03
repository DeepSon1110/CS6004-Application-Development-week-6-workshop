public class Program 
{ 
    public static void ProcessNumber(int[] numbers,Func <int, bool> condition)
    {
        foreach(int number in numbers)
        {
            if(condition(number))
            {
                Console.WriteLine(number);
            }
        }
        Console.WriteLine();
    }

    public static bool IsEven(int number) => number % 2 == 0;
    public static bool IsGreaterThanTen(int number) => number > 10;

    public static void Main() 
    { 
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; 
        Console.WriteLine("Even Numbers:"); 
        ProcessNumber(numbers, IsEven); 
        Console.WriteLine("Numbers Greater Than Ten:"); 
        ProcessNumber(numbers, IsGreaterThanTen); 
    }
}
