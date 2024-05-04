namespace playground;

public class SumDistance2731
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
                l.Add((long)nums[i] + d);
            else
                l.Add((long)nums[i] - d);
        }
        l.Sort();
        long res = 0, pre = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            res = (res + i * l[i] - pre) % MOD;
            pre += l[i];
        }
        return (int)res;
    }
}
