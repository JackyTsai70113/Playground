using System.Diagnostics.Metrics;

namespace playground;

public class Makesquare0473
{
    /// <summary>
    /// https://leetcode.com/problems/matchsticks-to-square
    /// </summary>
    public static bool Makesquare(int[] A)
    {
        int sum = A.Sum();
        if (sum % 4 != 0) return false;
        Array.Sort(A);
        return Dfs(A, new int[4], A.Length - 1, sum / 4);
    }

    private static bool Dfs(int[] A, int[] sides, int start, int target)
    {
        if (start == -1) return true;
        for (int i = 0; i < 4; i++)
        {
            if (sides[i] + A[start] <= target &&
                (i == 0 || sides[i - 1] != sides[i]))
            {
                sides[i] += A[start];
                if (Dfs(A, sides, start - 1, target)) return true;
                sides[i] -= A[start];
            }
        }
        return false;
    }
}
