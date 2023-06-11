namespace playground.Simulation;

public class SumDistanceClass
{
    /// <summary>
    /// https://leetcode.com/problems/movement-of-robots
    /// </summary>
    public static int SumDistance(int[] nums, string s, int d)
    {
        int MOD = (int)1e9 + 7;
        var l = new List<long>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (s[i] == 'R')
                l.Add(nums[i] + d);
            else
                l.Add(nums[i] - d);
        }
        l.Sort();
        long res = 0, pre = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            pre += l[i];
            res = (res + (i + 1) * l[i] - pre) % MOD;
        }
        return (int)res;
    }
}
