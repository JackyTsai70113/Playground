namespace playground;

public class _3134_MedianOfUniquenessArray
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-median-of-the-uniqueness-array
    /// </summary>
    /// <remarks>
    /// use sliding window to count subarray with at most k different number
    /// use binary search to find the smallest k<br/>
    /// `atmost(k) >= total - atmost(k)`
    /// </remarks>
    public static int MedianOfUniquenessArray(int[] nums)
    {
        int n = nums.Length, l = 1, r = n;
        long total = (long)n * (n + 1) / 2;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (AtMost(nums, m) * 2 >= total)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    static long AtMost(int[] nums, int k)
    {
        var d = new Dictionary<int, int>();
        int count = 0;
        long res = 0;
        bool Valid(int count)
        {
            return count <= k;
        }
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            int val = d.GetValueOrDefault(nums[r]);
            if (val == 0)
            {
                count++;
            }
            d[nums[r]] = val + 1;
            while (!Valid(count))
            {
                d[nums[l]]--;
                if (d[nums[l]] == 0)
                {
                    count--;
                }
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
