namespace playground;

public class MaximumLength2981
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
                d[str] = d.ContainsKey(str) ? d[str] + count : count;
                if (d[str] >= 3) res = m;
            }
            i = j;
        }
        return res == 0 ? -1 : res;
    }
}
