internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int sum = 0;
        for (x = 2; x <= 5; x++)
        {
            for (int d = 1; d <= x; d++)
            {
                if (x % d == 0)
                {
                    sum = sum + d;
                }
            }
        }
        Console.WriteLine(sum);
    }
}