namespace playground.DynamicPrograming;

public class MinimumBeautifulSubstringsClass
{
    /// <summary>
    /// https://leetcode.com/problems/partition-string-into-minimum-beautiful-substrings
    /// </summary>
    public static int MinimumBeautifulSubstrings(string s)
    {
        var five = new int[8];
        five[0] = 1;
        for (int i = 1; i < five.Length; ++i)
            five[i] = five[i - 1] * 5;
        var set = new HashSet<int>(five);
        int dp(int cur)
        {
            if (cur == s.Length)
                return 0;
            if (s[cur] == '0')
                return -1;
            var res = int.MaxValue;
            for (int i = cur, v = 0; i < s.Length; ++i)
            {
                v = v * 2 + s[i] - '0';
                if (set.Contains(v))
                {
                    var d = dp(i + 1);
                    if (d != -1)
                    {
                        res = Math.Min(res, 1 + d);
                    }
                }
            }
            return res == int.MaxValue ? -1 : res;
        }
        return dp(0);
    }
}
