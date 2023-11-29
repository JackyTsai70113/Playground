namespace playground;

public class TwoSum_0001
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum
    /// </summary>
    public static int[] TwoSum(int[] nums, int target)
    {
        var d = new Dictionary<int, int>();
        var res = new int[2];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (d.ContainsKey(target - nums[i]))
            {
                res = new[] { i, d[target - nums[i]] };
                break;
            }
            else
                d[nums[i]] = i;
        }
        return res;
    }
}
