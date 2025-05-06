namespace playground.LeetCode._1000_1999;

public class _1760_MinimumSize
{
    public static int MinimumSize(int[] nums, int maxOperations)
    {
        int l = 1, r = nums.Max();
        bool Valid(int[] nums, int ball)
        {
            int ops = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ops += (nums[i] - 1) / ball;
            }
            return ops <= maxOperations;
        }

        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (Valid(nums, m))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l;
    }
}
