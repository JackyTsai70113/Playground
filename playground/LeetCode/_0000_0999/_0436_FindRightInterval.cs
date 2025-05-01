namespace playground.LeetCode._0000_0999;

public class _0436_FindRightInterval
{
    /// <summary>
    /// https://leetcode.com/problems/find-right-interval
    /// </summary>
    public static int[] FindRightInterval(int[][] A)
    {
        var arr = A.Select((x, i) => new int[] { i, x[0], x[1] })
            .OrderBy(y => y[1]).ToArray();
        var res = new int[A.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            int l = i, r = arr.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (arr[m][1] >= arr[i][2])
                    r = m;
                else
                    l = m + 1;
            }
            res[arr[i][0]] = l < A.Length ? arr[l][0] : -1;
        }
        return res;
    }
}
