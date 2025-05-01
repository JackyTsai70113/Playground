namespace playground;

public class _3106_GetSmallestString
{
    /// <summary>
    /// https://leetcode.com/problems/lexicographically-smallest-string-after-operations-with-constraint
    /// </summary>
    public static string GetSmallestString(string s, int k)
    {
        var chs = s.ToCharArray();
        for (int i = 0; k > 0 && i < s.Length; i++)
        {
            if (Math.Min(s[i] - 'a', 'z' + 1 - s[i]) <= k)
            {
                k -= Math.Min(s[i] - 'a', 'z' + 1 - s[i]);
                chs[i] = 'a';
            }
            else
            {
                chs[i] = (char)(Math.Min((s[i] - 'a' + k) % 26, (s[i] - 'a' + 26 - k) % 26) + 'a');
                k = 0;
            }
        }
        return new string(chs);
    }
}
