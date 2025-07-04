namespace playground.LeetCode._0000_0999;

public class _0955_MinDeletionSize
{
    public static int MinDeletionSize(string[] strs)
    {
        int m = strs.Length, n = strs[0].Length, res = 0;
        int i = 0;
        var sorted = new bool[strs.Length - 1];
        for (int j = 0; j < n; j++)
        {
            for (i = 0; i < m - 1; i++)
            {
                if (!sorted[i] && strs[i][j] > strs[i + 1][j])
                {
                    res++;
                    break;
                }
            }
            if (i < m - 1) continue;
            for (i = 0; i < m - 1; i++)
            {
                sorted[i] |= strs[i][j] < strs[i + 1][j];
            }
        }
        return res;
    }
}
