namespace playground.HashTables;

public class CountBlackBlocksClass
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-black-blocks
    /// </summary>
    public static long[] CountBlackBlocks(int m, int n, int[][] A)
    {
        var res = new long[5];
        res[0] = (long)(m - 1) * (n - 1);
        var d = new Dictionary<long, int>();
        foreach (var a in A)
        {
            for (int i = a[0]; i < a[0] + 2; ++i)
            {
                for (int j = a[1]; j < a[1] + 2; j++)
                {
                    if (i > 0 && j > 0 && i < m && j < n)
                    {
                        var key = (long)i * 100000 + j;
                        d[key] = d.ContainsKey(key) ? d[key]+1 : 1;
                        res[d[key]-1]--;
                        res[d[key]]++;
                    }
                }
            }
        }
        return res;
    }
}
