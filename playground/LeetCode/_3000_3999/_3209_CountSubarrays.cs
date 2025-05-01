namespace playground;

public class _3209_CountSubarrays
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-subarrays-with-and-value-of-k
    /// </summary>
    public static long CountSubarrays(int[] nums, int k)
    {
        int n = nums.Length;
        var ands = new int[n + 1][];
        ands[0] = new int[32];
        for (int i = 0; i < n; i++)
        {
            ands[i + 1] = new int[32];
            for (int j = 0; j < 32; j++)
            {
                ands[i + 1][j] += ands[i][j] + (nums[i] >> j & 1);
            }
        }

        long res = 0;
        for (int i = 1; i <= n; i++)
        {
            int l = i, r = n + 1;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (SubAnds(ands, i - 1, m) <= k)
                    r = m;
                else
                    l = m + 1;
            }
            int left = l;
            l = i; r = n + 1;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (SubAnds(ands, i - 1, m) < k)
                    r = m;
                else
                    l = m + 1;
            }
            int right = l;
            res += right - left;
        }
        return res;
    }
    private static int SubAnds(int[][] ands, int l, int r)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            if (ands[r][i] - ands[l][i] == r - l)
                res |= 1 << i;
        }
        return res;
    }
}
