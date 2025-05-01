namespace playground.LeetCode._0000_0999;

public class _0058_LengthOfLastWord
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word
    /// </summary>
    public static int LengthOfLastWord(string s)
    {
        int res = 0;
        for (int i = s.Length - 1; i >= 0; --i)
        {
            if (s[i] != ' ')
            {
                res++;
            }
            else
            {
                if (res != 0)
                    break;
            }
        }
        return res;
    }
}
