namespace playground.LeetCode._0000_0999;

public class _0877_StoneGame
{
    public static bool StoneGame_TopDown(int[] A)
    {
        int n = A.Length, sum = A.Sum();
        var memo = new int[n, n];
        int MostStone(int l, int r)
        {
            if (l > r) return 0;
            if (memo[l, r] != 0) return memo[l, r];
            return memo[l, r] = Math.Max(A[l] + MostStone(l + 1, r), A[r] + MostStone(l, r - 1));
        }
        return MostStone(0, n - 1) * 2 > sum;
    }

    public static bool StoneGame_BottomUp(int[] A)
    {
        int n = A.Length, sum = A.Sum();
        var memo = new int[n + 1, n];
        for (int i = 0; i < n; i++)
        {
            memo[1, i] = A[i];
        }
        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                memo[len, i] = Math.Max(A[i + len - 1] + memo[len - 1, i], A[i] + memo[len - 1, i + 1]);
            }
        }
        return memo[n, 0] * 2 > sum;
    }

    public static bool StoneGame_OptimizeSpace(int[] A)
    {
        int n = A.Length, sum = A.Sum();
        var memo = new int[n];
        var memo2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            memo[i] = A[i];
        }
        for (int len = 2; len <= n; len++)
        {
            Array.Clear(memo2);
            for (int i = 0; i <= n - len; i++)
            {
                memo2[i] = Math.Max(A[i + len - 1] + memo[i], A[i] + memo[i + 1]);
            }
            (memo, memo2) = (memo2, memo);
        }
        return memo[0] * 2 > sum;
    }
}
