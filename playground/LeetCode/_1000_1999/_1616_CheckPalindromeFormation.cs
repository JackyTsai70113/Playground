namespace playground;

public class _1616_CheckPalindromeFormation
{
    /// <summary>
    /// https://leetcode.com/problems/split-two-strings-to-make-palindrome
    /// </summary>
    public static bool CheckPalindromeFormation(string a, string b)
    {
        return Check(a, b) | Check(b, a);
    }

    static bool Check(string a, string b)
    {
        int l = 0, r = a.Length - 1;
        while (l < r && a[l] == b[r])
        {
            l++;
            r--;
        }
        return IsPalindrome(a, l, r) || IsPalindrome(b, l, r);
    }

    static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }
        return true;
    }
}
