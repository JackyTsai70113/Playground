namespace playground;

public class _3152_IsArraySpecial
{
    /// <summary>
    /// https://leetcode.com/problems/special-array-ii
    /// </summary>
    public static bool[] IsArraySpecial(int[] nums, int[][] qs)
    {
        var presum = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++)
        {
            presum[i] = presum[i - 1];
            if (((nums[i - 1] & 1) ^ (nums[i] & 1)) == 0)
                presum[i]++;
        }
        var res = new List<bool>();
        foreach (var q in qs)
        {
            res.Add(presum[q[1]] == presum[q[0]]);
        }
        return res.ToArray();
    }
}
