namespace playground;

public class LongestValidSubstring2781
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-the-longest-valid-substring
    /// </summary>
    public static int LongestValidSubstring(string word, IList<string> forbidden)
    {
        var set = forbidden.ToHashSet();
        int res = 0, maxLength = set.Max(x => x.Length);
        for (int l = 0, r = 0; r < word.Length; r++)
        {
            for (int i = Math.Max(l, r - maxLength + 1); i <= r; i++)
            {
                if (set.Contains(word.Substring(i, r - i + 1)))
                {
                    l = i + 1;
                }
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
