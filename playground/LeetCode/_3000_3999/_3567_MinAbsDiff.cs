namespace playground.LeetCode._3000_3999;

public class _3567_MinAbsDiff
{
    public static int[][] MinAbsDiff(int[][] A, int k)
    {
        int m = A.Length, n = A[0].Length;
        var list = new List<int>();
        var res = new int[m - k + 1][];
        for (int i = 0; i < res.Length; i++)
            res[i] = new int[n - k + 1];

        for (int i = 0; i <= m - k; i++)
        {
            for (int j = 0; j <= n - k; j++)
            {
                list.Clear();
                for (int r = i; r < i + k; r++)
                {
                    for (int c = j; c < j + k; c++)
                    {
                        list.Add(A[r][c]);
                    }
                }

                int min = int.MaxValue;
                list = list.Distinct().OrderBy(x => x).ToList();
                for (int idx = 0; idx < list.Count - 1; idx++)
                {
                    min = Math.Min(min, list[idx + 1] - list[idx]);
                }
                res[i][j] = min == int.MaxValue ? 0 : min;
            }
        }
        return res;
    }
}
