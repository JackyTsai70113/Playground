namespace playground.LeetCode._2000_2999;

public class _2116_CanBeValid
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-a-parentheses-string-can-be-valid
    /// </summary>
    public static bool CanBeValid(string s, string locked)
    {
        if (s.Length % 2 != 0) return false;
        int max = 0, min = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (locked[i] == '1')
            {
                if (s[i] == '(')
                {
                    max++;
                    min++;
                }
                else
                {
                    if (max == 0) return false;
                    max--;
                    min--;
                }
            }
            else
            {
                max++;
                min--;
            }
            if (min < 0) min += 2;
        }
        return min == 0;
    }
}
