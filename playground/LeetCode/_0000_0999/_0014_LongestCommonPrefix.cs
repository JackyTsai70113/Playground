namespace playground.LeetCode._0000_0999;

public class _0014_LongestCommonPrefix
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix
    /// </summary>
    public static string LongestCommonPrefix(string[] strs)
    {
        for (int j = 0; j < strs[0].Length; ++j)
        {
            for (int i = 1; i < strs.Length; ++i)
            {
                if (j == strs[i].Length || strs[0][j] != strs[i][j])
                {
                    return strs[0].Substring(0, j);
                }
            }
        }
        return strs[0].Substring(0, strs[0].Length);
    }
}
