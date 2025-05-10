namespace playground.LeetCode._2000_2999;

public class _2555_MaximizeWin
{
    public static int MaximizeWin(int[] A, int k)
    {
        int max = 0;
        int[] maxsum = new int[A.Length + 1];
        int l = 0;
        for (int r = 0; r < A.Length; r++)
        {
            while (A[r] - A[l] > k)
            {
                l++;
            }
            int windowCount = r - l + 1;
            maxsum[r + 1] = Math.Max(windowCount, maxsum[r]);
            max = Math.Max(max, windowCount + maxsum[l]);
        }
        return max;
    }
}
