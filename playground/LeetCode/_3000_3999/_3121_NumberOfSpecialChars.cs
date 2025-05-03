namespace playground;

public class _3121_NumberOfSpecialChars
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-special-characters-ii
    /// </summary>
    public static int NumberOfSpecialChars(string word)
    {
        var valid = new int[26];
        var lower = new bool[26];
        var upper = new bool[26];
        foreach (var c in word)
        {
            if ('a' <= c && c <= 'z')
            {
                if (upper[c - 'a'])
                {
                    valid[c - 'a'] = 2;
                    continue;
                }
                lower[c - 'a'] = true;
            }
            else
            {
                if (lower[c - 'A'])
                {
                    if (valid[c - 'A'] == 0)
                    {
                        valid[c - 'A'] = 1;
                    }
                }
                upper[c - 'A'] = true;
            }
        }
        return valid.Count(x => x == 1);
    }
}
