namespace playground.Arrays;

public class MinDeletionClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-deletions-to-make-array-beautiful
    /// </summary>
    public static int MinDeletion(int[] nums)
    {
        int n = nums.Length, res = 0;
        var lens = new int[n];
        for (int i = 0; i < n; ++i)
        {
            lens[i] = 1;
            for (int j = i - 1; j >= 0; --j)
            {
                if (lens[j] % 2 == 1 && nums[i] != nums[j] || lens[j] % 2 == 0)
                {
                    lens[i] = Math.Max(lens[i], lens[j] + 1);
                    break;
                }
            }
            if (lens[i] % 2 == 0)
                res = Math.Max(res, lens[i]);
        }
        return n - res;
    }
}
