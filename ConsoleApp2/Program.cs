internal class Program
{
    private static void Main(string[] args)
    {
        int x = 15;

        int y = (x <= 0) || (x >= 10) ? 1 + x * 5 : 10 - 2 * x;

        Console.WriteLine(y);
    }
}