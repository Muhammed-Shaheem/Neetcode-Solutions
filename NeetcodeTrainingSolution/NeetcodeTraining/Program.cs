using NeetcodeTraining.Solutions;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = "carrace";
        string t = "racecar";

        Console.WriteLine(ValidAnagram.IsAnagram(s, t));

    }
}