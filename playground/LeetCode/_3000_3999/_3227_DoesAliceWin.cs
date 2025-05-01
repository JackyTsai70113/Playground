namespace playground;

public class _3227_DoesAliceWin
{
    public bool DoesAliceWin(string s)
    {
        var chs = (new char[] { 'a', 'e', 'i', 'o', 'u' }).ToHashSet();
        int count = 0;
        foreach (var c in s)
        {
            if (chs.Contains(c))
                count++;
        }

        return count != 0;
    }
}
