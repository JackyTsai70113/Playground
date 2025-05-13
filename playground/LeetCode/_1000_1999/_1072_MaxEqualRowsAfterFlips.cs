using System.Text;

namespace playground.LeetCode._1000_1999;

public class _1072_MaxEqualRowsAfterFlips
{
    public static int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        if (m == 1) return 1;
        if (n == 1) return m;
        var d = new Dictionary<string, int>();
        for (int i = 0; i < m; i++)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < n; j++)
            {
                sb.Append(matrix[i][0] == 0 ? matrix[i][j] : 1 - matrix[i][j]);
            }
            var str = sb.ToString();
            d[str] = d.GetValueOrDefault(str) + 1;
        }
        return d.Values.Max();
    }
}
