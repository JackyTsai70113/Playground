using System.Text;

namespace playground;

public class _1754_LargestMerge
{
    /// <summary>
    /// https://leetcode.com/problems/largest-merge-of-two-strings
    /// </summary>
    public static string LargestMerge(string s1, string s2)
    {
        StringBuilder sb = new();
        int i = 0, j = 0;
        while (i < s1.Length && j < s2.Length)
        {
            if (s1[i] > s2[j] || s1[i] == s2[j] && s1[i..].CompareTo(s2[j..]) > 0)
                sb.Append(s1[i++]);
            else
                sb.Append(s2[j++]);
        }
        sb.Append(i < s1.Length ? s1[i..] : s2[j..]);
        return sb.ToString();
    }
}
