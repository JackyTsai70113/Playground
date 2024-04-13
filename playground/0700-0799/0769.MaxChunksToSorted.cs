namespace playground;

public class MaxChunksToSorted0769
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
            if(max == i)
                res++;
        }
        return res;
    }
}
