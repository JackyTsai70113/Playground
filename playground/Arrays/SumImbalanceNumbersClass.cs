namespace playground.Arrays;

public class SumImbalanceNumbersClass
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-imbalance-numbers-of-all-subarrays
    /// </summary>
    public static int SumImbalanceNumbers(int[] nums)
    {
        int n = nums.Length, res = 0, imbalance;
        HashSet<int> set;
        for (int i = 0; i < n; i++)
        {
            imbalance = -1;
            set = new();
            for (int j = i; j < n; j++)
            {
                if (!set.Contains(nums[j]))
                {
                    if (!set.Contains(nums[j] - 1) && !set.Contains(nums[j] + 1))
                        imbalance++;
                    else if (set.Contains(nums[j] - 1) && set.Contains(nums[j] + 1))
                        imbalance--;
                    set.Add(nums[j]);
                }
                res += imbalance;
            }
        }
        return res;
    }
}
