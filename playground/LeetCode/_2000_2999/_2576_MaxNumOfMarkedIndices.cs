namespace playground.LeetCode._2000_2999;

public class _2576_MaxNumOfMarkedIndices
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-number-of-marked-indices
    /// </summary>
    public static int MaxNumOfMarkedIndices(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length, res = 0;
        for (int i = 0, j = n / 2; i < n / 2; i++)
        {
            int l = j, r = n;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] >= 2 * nums[i])
                    r = m;
                else
                    l = m + 1;
            }
            if (l < n)
            {
                res += 2;
            }
            j = l + 1;
        }
        return res;
    }
}
