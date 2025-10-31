using NeetcodeTraining.Solutions;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 2, 4, 5, 3, 1, 2 };
        var array = ReplaceElementSolution.ReplaceElements(arr);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }


    }
}