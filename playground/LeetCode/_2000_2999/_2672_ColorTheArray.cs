namespace playground.LeetCode._2000_2999;

public class _2672_ColorTheArray
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-adjacent-elements-with-the-same-color
    /// </summary>
    public static int[] ColorTheArray(int n, int[][] A)
    {
        var res = new int[A.Length];
        var arr = new int[n];
        int adjacent = 0;
        for (int i = 0; i < A.Length; ++i)
        {
            int index = A[i][0], color = A[i][1];
            if (arr[index] > 0)
            {
                if (arr[index] == arr[index - 1]) adjacent--;
                if (arr[index] == arr[index + 1]) adjacent--;
            }
            arr[index] = color;
            if (index > 0 && arr[index] == arr[index - 1]) adjacent++;
            if (index < n - 1 && arr[index] == arr[index + 1]) adjacent++;
            res[i] = adjacent;
        }
        return res;
    }
}
