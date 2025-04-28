namespace playground;

public class LongestPalindrome0005
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring
    /// </summary>
    public static string LongestPalindrome(string s)
    {
        int n = s.Length, maxl = 0, maxr = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int l = i, r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            if (r - l - 1 > maxr - maxl + 1)
            {
                maxl = l + 1;
                maxr = r - 1;
            }

            l = i; r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            if (r - l - 1 > maxr - maxl + 1)
            {
                maxl = l + 1;
                maxr = r - 1;
            }
        }
        return s.Substring(maxl, maxr - maxl + 1);
    }
}
