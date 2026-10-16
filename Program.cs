


using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int sum = Add(2, 3);

        Console.WriteLine("Debug vs Release");
        Console.WriteLine($"Add(2, 3) = {sum}");

        int n = 100_000_000;

        var sw = Stopwatch.StartNew();
        long result = SumTo(n);
        sw.Stop();

        Console.WriteLine($"SumTo({n:N0}) = {result:N0}");
        Console.WriteLine($"Время: {sw.Elapsed.TotalMilliseconds:F3} мс");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static long SumTo(int n)
    {
        long sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
