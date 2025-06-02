using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace playground.APCS;

public class F314_GetPoint
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=f314
    /// /// </summary>
    public static int GetPoint(int[][] arr)
    {
        int m = arr.Length, n = arr[0].Length;
        var dp = new int[n];
        var L = new int[n];
        var R = new int[n];
        for (int i = 0; i < m; i++)
        {
            L[0] = arr[i][0];
            for (int j = 1; j < n; j++)
            {
                L[j] = Math.Max(dp[j], L[j - 1]) + arr[i][j];
            }

            R[^1] = arr[i][^1];
            for (int j = n - 2; j >= 0; j--)
            {
                R[j] = Math.Max(dp[j], R[j + 1]) + arr[i][j];
            }

            for (int j = 0; j < n; j++)
            {
                dp[j] = Math.Max(L[j], R[j]);
            }
        }
        return dp.Max();
    }
}
