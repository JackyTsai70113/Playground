namespace playground.LeetCode._0000_0999;

public class _0344_ReverseString
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-string
    /// </summary>
    public static void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            (s[i], s[s.Length - 1 - i]) = (s[s.Length - 1 - i], s[i]);
        }
    }
}
