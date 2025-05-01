namespace playground.LeetCode._2000_2999;

public class _2952_MinimumAddedCoins
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-coins-to-be-added
    /// </summary>
    public static int MinimumAddedCoins(int[] A, int target)
    {
        Array.Sort(A);
        int lastMiss = 1; // 預設能產出的範圍為 [1, 1)
        int i = 0, res = 0;
        while (lastMiss <= target)
        {
            if (i < A.Length && lastMiss >= A[i])
            {
                // [1, lastMiss) + A[i] 更新成  [1, lastMiss + A[i])
                lastMiss += A[i++];
            }
            else
            {
                // [1, lastMiss) + A[i] 更新成  [1, lastMiss * 2)
                res++;
                lastMiss *= 2;
            }
        }
        return res;
    }
}
