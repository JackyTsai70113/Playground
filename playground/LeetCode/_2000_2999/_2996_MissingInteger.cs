namespace playground.LeetCode._2000_2999;

public class _2996_MissingInteger
{
    /// <summary>
    /// https://leetcode.com/problems/smallest-missing-integer-greater-than-sequential-prefix-sum
    /// </summary>
    public static int MissingInteger(int[] nums)
    {
        var sum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 == nums[i])
            {
                sum += nums[i];
            }
            else
            {
                break;
            }
        }
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == sum)
            {
                sum++;
            }
        }
        return sum;
    }
}
