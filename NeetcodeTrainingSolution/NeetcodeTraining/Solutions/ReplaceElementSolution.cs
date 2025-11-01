namespace NeetcodeTraining.Solutions;

public class ReplaceElementSolution
{
    public static int[] ReplaceElements(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
                arr[i] = -1;
                break;
            }

            int greatest = arr[i + 1];


            for (int j = i + 1; j < length; j++)
            {


                if (arr[j] > greatest)
                {
                    greatest = arr[j];
                }

            }
            arr[i] = greatest;

        }
        return arr;
    }

    public static int[] ReplaceElements1(int[] arr)
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
