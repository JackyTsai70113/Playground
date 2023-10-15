namespace playground.SlidingWindow;

public class ShortestBeautifulSubstringClass
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-and-lexicographically-smallest-beautiful-string
    /// </summary>
    public static string ShortestBeautifulSubstring(string s, int k)
    {
        var res = string.Empty;
        int l = 0, r = 0;
        for (; r < s.Length; ++r)
        {
            if (s[r] == '1')
                k--;
            while (k < 0)
            {
                if (s[l] == '1')
                {
                    k++;
                }
                l++;
            }
            if (k == 0)
            {
                while (s[l] != '1')
                {
                    l++;
                }
                var temp = s.Substring(l, r - l + 1);
                if (res == string.Empty || temp.Length < res.Length || (temp.Length == res.Length && string.Compare(temp, res) == -1))
                    res = temp;
            }
        }
        return res;
    }
}
