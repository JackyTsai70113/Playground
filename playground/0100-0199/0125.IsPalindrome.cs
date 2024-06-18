namespace playground;

public class IsPalindrome0125
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome
    /// </summary>
    public static bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (!char.IsLetter(s[l]))
                l++;
            else if (!char.IsLetter(s[r]))
                r--;
            else if (char.ToLower(s[l++]) != char.ToLower(s[r--]))
                return false;
        }
        return true;
    }
}
