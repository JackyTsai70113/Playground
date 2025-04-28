namespace playground;

public class LengthOfLastWord_0058
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
