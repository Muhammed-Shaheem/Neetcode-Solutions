namespace NeetcodeTraining.Solutions;

public static class ContainsDuplicate
{
    public static bool HasDuplicate(int[] nums)
    {
        HashSet<int> ints = new();

        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            bool contains = ints.Add(nums[i]);

            if (contains == false)
            {
                return true;
            }
        }

        return false;
    }
}
