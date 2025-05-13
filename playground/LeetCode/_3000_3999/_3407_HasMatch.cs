namespace playground.LeetCode._3000_3999;

public class _3407_HasMatch
{
    public static bool HasMatch(string s, string p)
    {
        int index = p.IndexOf("*");
        string start = p.Substring(0, index);
        string end = p.Substring(index + 1);
        int i = s.IndexOf(start);
        int j = s.LastIndexOf(end);
        return i != -1 && j != -1 && i + start.Length <= j;
    }
}
