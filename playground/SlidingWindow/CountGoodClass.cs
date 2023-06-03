namespace playground.SlidingWindow;

public class CountGoodClass
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-good-subarrays
    /// </summary>
    public static long CountGood(int[] nums, int k)
    {
        int n = nums.Length, pairs = 0;
        long res = 0;
        Dictionary<int, int> d = new();
        for (int l = 0, r = 0; l < n; ++l)
        {
            if (l > 0)
            {
                if (d[nums[l - 1]] >= 2) pairs -= d[nums[l - 1]] - 1;
                d[nums[l - 1]]--;
            }
            while (r < n && pairs < k)
            {
                d[nums[r]] = d.TryGetValue(nums[r], out var v) ? v + 1 : 1;
                if (d[nums[r]] >= 2) pairs += d[nums[r]] - 1;
                r++;
            }
            if (pairs >= k)
            {
                res += n - r + 1;
            }
            else
            {
                if (r == n)
                    break;
            }
        }
        return res;
    }
}
