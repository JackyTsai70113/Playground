namespace playground;

public class CountBlackBlocks2768
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-black-blocks
    /// </summary>
    public static long[] CountBlackBlocks(int m, int n, int[][] A)
    {
        long[] res = new long[] { (long)(m - 1) * (n - 1), 0, 0, 0, 0 };
        var d = new Dictionary<(int, int), int>();
        foreach (var a in A)
        {
            for (int i = a[0]; i <= a[0] + 1; i++)
            {
                for (int j = a[1]; j <= a[1] + 1; j++)
                {
                    if (i > 0 & j > 0 && i < m && j < n)
                    {
                        d[(i, j)] = d.ContainsKey((i, j)) ? d[(i, j)] + 1 : 1;
                        res[d[(i, j)] - 1]--;
                        res[d[(i, j)]]++;
                    }
                }
            }
        }
        return res;
    }
}
