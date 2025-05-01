namespace playground.LeetCode._2000_2999;

public class _2981_MaximumLength
{
    /// <summary>
    /// https://leetcode.com/problems/find-longest-special-substring-that-occurs-thrice-ii
    /// </summary>
    public static int MaximumLength(string s)
    {
        var d = new Dictionary<string, int>();
        int res = -1, i = 0;
        while (i + res < s.Length)
        {
            int j = i + 1;
            while (j < s.Length && s[i] == s[j]) j++;

            for (int m = j - i, count = 1; m > res; m--, count++)
            {
                var str = s.Substring(i, m);
                d[str] = d.GetValueOrDefault(str) + count;
                if (d[str] >= 3) res = m;
            }
            i = j;
        }
        return res == 0 ? -1 : res;
    }
}
