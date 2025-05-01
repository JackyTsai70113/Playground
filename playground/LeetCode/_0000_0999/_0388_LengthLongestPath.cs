namespace playground.LeetCode._0000_0999;

public class _0388_LengthLongestPath
{
    /// <summary>
    /// https://leetcode.com/problems/longest-absolute-file-path
    /// </summary>
    public static int LengthLongestPath(string input)
    {
        var strs = input.Split('\n');
        var lens = new int[strs.Length + 1];
        int res = 0;
        foreach (var str in strs)
        {
            int level = str.LastIndexOf('\t') + 1;
            lens[level + 1] = lens[level] + str.Length - level + 1;
            if (str.Contains('.'))
                res = Math.Max(res, lens[level + 1] - 1);
        }
        return res;
    }
}
