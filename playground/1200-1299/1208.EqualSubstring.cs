namespace playground;

public class EqualSubstring1208
{
    /// <summary>
    /// https://leetcode.com/problems/get-equal-substrings-within-budget
    /// </summary>
    public static int EqualSubstring(string s, string t, int maxCost)
    {
        var res = 0;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            maxCost -= Math.Abs(s[r] - t[r]);
            while (maxCost < 0)
            {
                maxCost += Math.Abs(s[l] - t[l]);
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
