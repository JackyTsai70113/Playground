namespace playground.LeetCode._3000_3999;

public class _3120_NumberOfSpecialChars
{
    public static int NumberOfSpecialChars(string word)
    {
        var valid = new bool[26];
        var lower = new bool[26];
        var upper = new bool[26];
        foreach (var c in word)
        {
            if ('a' <= c && c <= 'z')
            {
                lower[c - 'a'] = true;
                if (upper[c - 'a'])
                    valid[c - 'a'] = true;
            }
            else
            {
                upper[c - 'A'] = true;
                if (lower[c - 'A'])
                    valid[c - 'A'] = true;
            }
        }
        return valid.Count(x => x == true);
    }
}
