namespace playground;

public class CountSubstrings0647
{
    /// <summary>
    /// https://leetcode.com/problems/palindromic-substrings
    /// </summary>
    public static int CountSubstrings(string s)
    {
        int n = s.Length, res = 0;
        for (int l = 0; l < n; l++)
        {
            int r = l, i = 0;
            while (l - i >= 0 && r + i < n && s[l - i] == s[r + i])
                i++;
            res += i;

            r = l + 1; i = 0;
            while (l - i >= 0 && r + i < n && s[l - i] == s[r + i])
                i++;
            res += i;
        }
        return res;
    }
}
