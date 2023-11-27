namespace playground;

public class MaximizeSquareHoleArea_2943
{
    /// <summary>
    /// https://leetcode.com/problems/maximize-area-of-square-hole-in-grid
    /// </summary>
    public static int MaximizeSquareHoleArea(int[] A, int[] B)
    {
        Array.Sort(A);
        int max1 = 2;
        for (int i = 1, cur = 2; i < A.Length; ++i)
        {
            cur = A[i - 1] + 1 == A[i] ? cur + 1 : 2;
            max1 = Math.Max(max1, cur);
        }

        Array.Sort(B);
        int max2 = 2;
        for (int i = 1, cur = 2; i < B.Length; ++i)
        {
            cur = B[i - 1] + 1 == B[i] ? cur + 1 : 2;
            max2 = Math.Max(max2, cur);
        }

        int min = Math.Min(max1, max2);
        return min * min;
    }
}
