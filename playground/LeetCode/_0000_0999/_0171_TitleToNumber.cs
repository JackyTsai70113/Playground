namespace playground.LeetCode._0000_0999;

public class _0171_TitleToNumber
{
    /// <summary>
    /// https://leetcode.com/problems/excel-sheet-column-number
    /// </summary>
    public static int TitleToNumber(string A)
    {
        var res = 0;
        foreach (var c in A)
            res = res * 26 + c - 'A' + 1;
        return res;
    }
}
