namespace playground.LeetCode._3000_3999;

public class _3446_SortMatrix
{
    public static int[][] SortMatrix(int[][] A)
    {
        int n = A.Length;
        var res = new int[n][];
        for (int i = 0; i < n; i++)
            res[i] = new int[n];
        for (int j = 1; j < n; j++)
        {
            var l = new List<int>();
            for (int i = 0; i + j < n; i++)
            {
                l.Add(A[i][i + j]);
            }
            l.Sort();
            for (int i = 0, k = 0; i + j < n; i++)
            {
                res[i][i + j] = l[k++];
            }
        }

        for (int i = 0; i < n; i++)
        {
            var l = new List<int>();
            for (int j = 0; i + j < n; j++)
            {
                l.Add(A[i + j][j]);
            }
            l.Sort((x, y) => y - x);
            for (int j = 0, k = 0; i + j < n; j++)
            {
                res[i + j][j] = l[k++];
            }
        }
        return res;
    }
}
