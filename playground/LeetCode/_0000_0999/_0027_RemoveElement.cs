namespace playground.LeetCode._0000_0999;

public class _0027_RemoveElement
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element
    /// </summary>
    public static int RemoveElement(int[] nums, int val)
    {
        int idx = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != val)
            {
                nums[idx++] = nums[i];
            }
        }
        return idx;
    }
}
