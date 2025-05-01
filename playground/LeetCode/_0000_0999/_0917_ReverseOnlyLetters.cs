using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0917_ReverseOnlyLetters
{
    public static string ReverseOnlyLetters(string s)
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
