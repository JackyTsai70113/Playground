namespace playground.LeetCode._2000_2999;

public class _2009_MinOperations
{
    public static int MinOperations(int[] nums)
    {
        int n = nums.Length;
        int uniqueLen = 1;
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                nums[uniqueLen++] = nums[i];
            }
        }
        bool Valid(int l, int r)
        {
            return nums[r] - nums[l] <= n - 1;
        }
        int l = 0, max = 0;
        for (int r = 0; r < uniqueLen; r++)
        {
            // update state by A[r]
            while (!Valid(l, r))
            {
                // update state by A[l]
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return n - max;
    }
}
