namespace playground;

public class _3083_IsSubstringPresent
{
    /// <summary>
    /// https://leetcode.com/problems/existence-of-a-substring-in-a-string-and-its-reverse
    /// </summary>
    public static bool IsSubstringPresent(string s)
    {
        var set = new HashSet<string>();
        for (int i = 0; i < s.Length - 1; i++)
        {
            set.Add((s[i].ToString() + s[i + 1]));
            if (set.Contains(s[i + 1].ToString() + s[i]))
                return true;
        }
        return false;
    }
}
