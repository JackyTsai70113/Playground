namespace playground.LeetCode._0000_0999;

public class _0678_CheckValidString
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parenthesis-string
    /// </summary>
    public static bool CheckValidString(string s)
    {
        int max = 0, min = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                max++;
                min++;
            }
            else if (c == ')')
            {
                max--;
                min--;
            }
            else
            {
                max++;
                min--;
            }
            if (max < 0)
                return false;
            min = Math.Max(min, 0);
        }
        return min == 0;
    }
}
