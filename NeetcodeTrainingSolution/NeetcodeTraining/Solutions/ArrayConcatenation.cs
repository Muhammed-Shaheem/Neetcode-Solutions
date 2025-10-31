namespace NeetcodeTraining.Solutions;

public class ArrayConcatenation
{
    public static int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];

        int ansLength = ans.Length;
        int numsLength = nums.Length;

        for (int i = 0; i < ansLength; i++)
        {
            ans[i] = nums[i%numsLength];
        }
        return ans;
    }
}
