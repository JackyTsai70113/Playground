namespace playground;

public class BeautifulSubstrings_2947
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
