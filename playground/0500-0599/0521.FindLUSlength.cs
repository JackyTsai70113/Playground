namespace playground;

public class FindLUSlength0521
{
    public static int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        return a.Length > b.Length ? a.Length : b.Length;
    }
}
