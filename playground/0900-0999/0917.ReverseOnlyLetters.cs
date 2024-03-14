using System.Text;

namespace playground;

public class ReverseOnlyLetters0917
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-only-letters
    /// </summary>
    public string ReverseOnlyLetters(string s)
    {
        StringBuilder sb = new(s);
        int n = s.Length, l = 0, r = n - 1;
        while (l < r)
        {
            while (!char.IsLetter(s, l)) l++;
            while (l < r && !char.IsLetter(s, r)) r--;
            if (l < r) (sb[l], sb[r]) = (sb[r], sb[l]);
            l++; r--;
        }
        return sb.ToString();
    }
}
