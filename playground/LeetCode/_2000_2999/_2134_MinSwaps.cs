namespace playground.LeetCode._2000_2999;

public class _2134_MinSwaps
{
    public static int MinSwaps(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return 0;

        int k = nums.Count(x => x == 1), min = n;
        for (int i = 0, cur = 0; i < 2 * n; i++)
        {
            if (nums[i % n] == 0)
                cur++;
            if (i >= k && nums[(i - k) % n] == 0)
                cur--;
            if (i >= k - 1)
                min = Math.Min(min, cur);
        }
        return min;
    }
}
