using NeetcodeTraining.Solutions;

internal class Program
{
    private static void Main(string[] args)
    {
       var ints= TwoSumSolution.TwoSum(new int[] { 2, 3, 67, 32, 4 }, 36);

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }

    }
}