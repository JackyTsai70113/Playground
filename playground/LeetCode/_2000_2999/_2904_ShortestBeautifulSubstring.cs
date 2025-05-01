namespace playground.LeetCode._2000_2999;

public class _2904_ShortestBeautifulSubstring
{
    // O(n)/O(n)
    public static string ShortestBeautifulSubstring(string s, int k)
    {
        var res = string.Empty;
        int remainingOnes = k;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            if (s[r] == '1')
            {
                remainingOnes--;
            }
            while (remainingOnes < 0)
            {
                if (s[l] == '1')
                {
                    remainingOnes++;
                }
                l++;
            }
            if (remainingOnes == 0)
            {
                while (s[l] != '1')
                    l++;
                var currentSubstring = s.Substring(l, r - l + 1);
                if (res == string.Empty ||
                    currentSubstring.Length < res.Length ||
                    currentSubstring.Length == res.Length && currentSubstring.CompareTo(res) < 0)
                    res = currentSubstring;
            }
        }
        return res;
    }
}
