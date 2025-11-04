namespace NeetcodeTraining.Solutions;

public class ReplaceElementSolution
{
  

    public static int[] ReplaceElements(int[] arr)
    {
        int length = arr.Length;
        int greatestToRight = arr[length - 1];
        var temp = arr[length - 1];
        for (int i = length - 1; i >= 0; i--)
        {
            if (i == length - 1)
            {
                arr[i] = -1;
                continue;
            }

            greatestToRight = Math.Max(greatestToRight, temp);
            arr[i] = greatestToRight;

            temp = arr[i];


        }
        return arr;
    }
}
