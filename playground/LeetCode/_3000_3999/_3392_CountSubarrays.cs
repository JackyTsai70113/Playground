namespace playground.LeetCode._3000_3999;

public class _3392_CountSubarrays
{
    public static int CountSubarrays(int[] nums)
    {
        var res = 0;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] == (nums[i - 1] + nums[i + 1]) * 2)
                res++;
        }
        return res;
    }
}
