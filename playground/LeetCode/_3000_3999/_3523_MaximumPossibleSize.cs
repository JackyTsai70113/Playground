namespace playground.LeetCode._3000_3999;

public class _3523_MaximumPossibleSize
{
    public static int MaximumPossibleSize(int[] nums)
    {
        int max = 0, res = 0;
        foreach (var num in nums)
        {
            if (num >= max)
            {
                res++;
                max = num;
            }
        }
        return res;
    }
}
