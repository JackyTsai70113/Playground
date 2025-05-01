namespace playground;

public class _3095_MinimumSubarrayLength
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-subarray-with-or-at-least-k-i
    /// </summary>
    public static int MinimumSubarrayLength(int[] nums, int k)
    {
        int res = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            var cur = 0;
            int j = i;
            for (; j < nums.Length; j++)
            {
                cur |= nums[j];
                if (cur >= k)
                    break;
            }
            if (cur >= k) res = Math.Min(res, j - i + 1);
        }
        return res == int.MaxValue ? -1 : res;
    }
}
