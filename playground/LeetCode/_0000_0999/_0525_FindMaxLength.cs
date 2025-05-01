namespace playground.LeetCode._0000_0999;

public class _0525_FindMaxLength
{
    /// <summary>
    /// https://leetcode.com/problems/contiguous-array
    /// </summary>
    public static int FindMaxLength(int[] nums)
    {
        var d = new Dictionary<int, int>();
        d.Add(0, -1);
        var res = 0;
        for (int i = 0, presum = 0; i < nums.Length; i++)
        {
            presum += nums[i] == 0 ? -1 : 1;
            if (d.ContainsKey(presum))
            {
                res = Math.Max(res, i - d[presum]);
            }
            else
            {
                d[presum] = i;
            }
        }
        return res;
    }
}
