namespace NeetcodeTraining.Solutions;

public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new();
        int length = nums.Length;

    
        for (int i = 0; i < length; i++)
        {
            int x = target - nums[i];

            if (keyValuePairs.ContainsKey(x) && i != keyValuePairs[x])
            {
                   
                return new int[] {keyValuePairs[x],i };
            }
            else
            {
                keyValuePairs[nums[i]] = i;
            }
        }

        return new int[] { 1, 2 };
    }
}
