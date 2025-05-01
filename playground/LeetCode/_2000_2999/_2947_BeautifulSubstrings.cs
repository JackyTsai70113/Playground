namespace playground.LeetCode._2000_2999;

public class _2947_BeautifulSubstrings
{
    /// <summary>
    /// https://leetcode.com/problems/count-beautiful-substrings-i
    /// </summary>
    public static int BeautifulSubstrings(string s, int k)
    {
        var vs = new char[] { 'a', 'e', 'i', 'o', 'u' }.ToHashSet();
        int n = s.Length, res = 0;
        for (int i = 0; i < n; i++)
        {
            int vo = 0;
            for (int j = i; j < n; j++)
            {
                if (vs.Contains(s[j])) vo++;
                if (vo * 2 == j - i + 1 && vo * vo % k == 0)
                    res++;
            }
        }
        return res;
    }
}
