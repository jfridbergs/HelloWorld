internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("What is your name?");
        Console.WriteLine("-----------------");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}