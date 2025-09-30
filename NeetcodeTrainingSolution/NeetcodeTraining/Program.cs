using NeetcodeTraining.Solutions;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, int> d = new();

        d.Add(5, 0);
        d.Add(5, 1);

        Console.WriteLine(d[5]);

    }
}