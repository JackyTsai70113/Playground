namespace playground.Strings;

public class IsFascinatingClass
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-the-number-is-fascinating/
    /// </summary>
    public static bool IsFascinating(int n)
    {
        var str = n.ToString() + (2 * n).ToString() + (3 * n).ToString();
        var hs = str.Where(c => c != '0').ToHashSet();
        return str.Length == 9 && hs.Count == 9;
    }
}
