internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 1;
        int c = 6;
        int d = 7;
        int i = 1;
        while (i < 4)
        {
            a++;
            b -= a;
            c = b - a;
            d = (c + a) + i;
            i++;
        }
        Console.WriteLine(d);
    }
}