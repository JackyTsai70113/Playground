namespace playground.LeetCode._0000_0999;

public class _0521_FindLUSlength
{
    public static int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        return a.Length > b.Length ? a.Length : b.Length;
    }
}
