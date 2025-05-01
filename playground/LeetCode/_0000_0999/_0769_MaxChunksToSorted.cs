namespace playground.LeetCode._0000_0999;

public class _0769_MaxChunksToSorted
{
    /// <summary>
    /// https://leetcode.com/problems/max-chunks-to-make-sorted
    /// </summary>
    public static int MaxChunksToSorted(int[] arr)
    {
        int n = arr.Length, max = arr[0], res = 0;
        for (int i = 0; i < n; i++)
        {
            max = Math.Max(max, arr[i]);
            if (max == i)
                res++;
        }
        return res;
    }
}
