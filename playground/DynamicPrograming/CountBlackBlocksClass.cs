namespace playground.DynamicPrograming;

public class CountBlackBlocksClass
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-black-blocks
    /// </summary>
    public static long[] CountBlackBlocks(int m, int n, int[][] A)
    {
        var res = new long[5];
        var B = new bool[m, n];
        foreach (var a in A)
        {
            B[a[0], a[1]] = true;
        }
        var C = new int[m + 1, n + 1];
        for (int i = 1; i <= m; ++i)
        {
            for (int j = 1; j <= n; ++j)
            {
                C[i, j] = C[i, j - 1] + C[i - 1, j] - C[i - 1, j - 1];
                if (B[i - 1, j - 1]) C[i, j]++;
                if (i >= 2 && j >= 2)
                {
                    int count = C[i, j] - C[i, j - 2] - C[i - 2, j] + C[i - 2, j - 2];
                    res[count]++;
                }
            }
        }
        return res;
    }
}
