namespace playground.Arrays;

public class ColorTheArrayClass
{
    /// <remarks>https://leetcode.com/problems/number-of-adjacent-elements-with-the-same-color/</remarks>
    public static int[] ColorTheArray(int n, int[][] queries)
    {
        var res = new List<int>();
        var arr = new int[n];
        int m = 0;
        foreach (var q in queries)
        {
            if (arr[q[0]] > 0)
            {
                if (q[0] > 0 && arr[q[0]] == arr[q[0] - 1]) m--;
                if (q[0] < n - 1 && arr[q[0]] == arr[q[0] + 1]) m--;
            }
            arr[q[0]] = q[1];
            if (q[0] > 0 && arr[q[0]] == arr[q[0] - 1]) m++;
            if (q[0] < n - 1 && arr[q[0]] == arr[q[0] + 1]) m++;
            res.Add(m);
        }
        return res.ToArray();
    }
}
