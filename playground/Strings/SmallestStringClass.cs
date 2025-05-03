namespace playground.Strings;

public class SmallestStringClass
{
    /// <summary>
    /// https://leetcode.com/problems/lexicographically-smallest-string-after-substring-operation
    /// </summary>
    public static string SmallestString(string s)
    {
        var chs = s.ToArray();
        bool changed = false;
        for (int i = 0; i < s.Length; ++i)
        {
            if (chs[i] > 'a')
            {
                chs[i] = (char)(chs[i] - 1);
                changed = true;
            }
            else if (changed)
            {
                break;
            }
        }
        if (!changed)
        {
            chs[^1] = 'z';
        }
        return new string(chs);
    }
}
