namespace playground;

public class RemoveDuplicates_0080
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
    /// </summary>
    public static int RemoveDuplicates(int[] nums)
    {
        int j = 0, k = 2, count = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[j] != nums[i])
            {
                nums[++j] = nums[i];
                count = 1;
            }
            else if (count < k)
            {
                nums[++j] = nums[i];
                count++;
            }
        }
        return j + 1;
    }
}
