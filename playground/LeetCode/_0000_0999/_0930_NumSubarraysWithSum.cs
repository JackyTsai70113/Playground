namespace playground.LeetCode._0000_0999;

public class _0930_NumSubarraysWithSum
{
    public static int NumSubarraysWithSum(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        if (k < 0) return 0;
        bool Valid()
        {
            return k >= 0;
        }
        int l = 0, res = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            k -= nums[r];
            while (!Valid())
                k += nums[l++];
            res += r - l + 1;
        }
        return res;
    }
}
