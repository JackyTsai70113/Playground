namespace playground;

public class _3225_MaximumScore
{
    public static long MaximumScore(int[][] A)
    {
        int n = A.Length;
        if (n == 1) return 0;
        long[] prev_col_w = new long[n + 1], prev_col_wo = new long[n + 1];
        long[] cur_col_w = new long[n + 1], cur_col_wo = new long[n + 1];
        long prev_col_val, cur_col_val;
        for (int j = 1; j < n; j++)
        {
            cur_col_w = new long[n + 1];
            cur_col_wo = new long[n + 1];
            for (int i = 0; i <= n; i++) // prev col is black from row 0 to row i-1
            {
                prev_col_val = cur_col_val = 0;
                for (int k = 0; k < i; k++)
                    cur_col_val += A[k][j];
                for (int k = 0; k <= n; k++) // cur col is black from row 0 to row k-1
                {
                    if (k > 0 && k <= i)
                    {
                        cur_col_val -= A[k - 1][j];
                    }
                    if (k > i)
                    {
                        prev_col_val += A[k - 1][j - 1];
                    }
                    cur_col_w[k] = Math.Max(cur_col_w[k], cur_col_val + prev_col_w[i]);
                    cur_col_w[k] = Math.Max(cur_col_w[k], cur_col_val + prev_col_val + prev_col_wo[i]);
                    cur_col_wo[k] = Math.Max(cur_col_wo[k], prev_col_val + prev_col_wo[i]);
                    cur_col_wo[k] = Math.Max(cur_col_wo[k], prev_col_w[i]);
                }
            }
            prev_col_w = cur_col_w;
            prev_col_wo = cur_col_wo;
        }
        return cur_col_w.Max();
    }
}
