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
            int greatest = arr[i+1];

           
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
}
