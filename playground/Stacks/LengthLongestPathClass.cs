namespace playground.Stacks;

public class LengthLongestPathClass
{
    /// <remarks>https://leetcode.com/problems/longest-absolute-file-path</remarks>
    public static int LengthLongestPath(string input)
    {
        int res = 0;
        var cache = new int[input.Split('\n').Length + 1];
        foreach (var str in input.Split('\n'))
        {
            int level = str.LastIndexOf('\t') + 1;
            int curLen = cache[level + 1] = cache[level] + str.Length - level + 1;
            if (str.Contains('.')) res = Math.Max(res, curLen - 1);
        }
        return res;
    }
}
