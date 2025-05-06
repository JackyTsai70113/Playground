namespace playground.LeetCode._1000_1999;

public class _1737_MinCharacters
{
    public static int MinCharacters(string a, string b)
    {
        return Math.Min(
            Math.Min(Operation1(a, b), Operation1(b, a)),
            Operation2(a, b)
        );
    }
    static int Operation1(string a, string b)
    {
        int res = a.Length + b.Length;
        for (char c = 'a'; c < 'z'; c++)
        {
            int cur = a.Length + b.Length;
            foreach (var cc in a)
            {
                if (cc <= c)
                    cur--;
            }
            foreach (var cc in b)
            {
                if (cc > c)
                    cur--;
            }
            res = Math.Min(res, cur);
        }
        return res;
    }
    static int Operation2(string a, string b)
    {
        var chs = new int[26];
        foreach (var c in a) chs[c - 'a']++;
        foreach (var c in b) chs[c - 'a']++;
        return a.Length + b.Length - chs.Max();
    }
}
