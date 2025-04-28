namespace playground;

public class RemoveDuplicates_0026
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array
    /// </summary>
    public static int RemoveDuplicates(int[] nums)
    {
        int idx = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != nums[idx])
                nums[++idx] = nums[i];
        }
        return idx + 1;
    }
}
