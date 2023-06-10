namespace playground.Strings;

public class MinimizedStringLengthClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-string-length
    /// </summary>
    public static int MinimizedStringLength(string s)
    {
        return new HashSet<char>(s).Count;
    }
}
