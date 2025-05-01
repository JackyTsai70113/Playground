namespace playground.LeetCode._2000_2999;

public class _2824_CountPairs
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target
    /// </summary>
    public static int CountPairs(IList<int> nums, int target)
    {
        var res = 0;
        for (int i = 0; i < nums.Count - 1; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                    res++;
            }
        }
        return res;
    }
}
