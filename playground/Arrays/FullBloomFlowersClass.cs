namespace playground.Arrays;

public class FullBloomFlowersClass
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-flowers-in-full-bloom
    /// </summary>
    public static int[] FullBloomFlowers(int[][] flowers, int[] people)
    {
        var start = flowers.Select(f => f[0]).OrderBy(f => f).ToArray();
        var end = flowers.Select(f => f[1] + 1).OrderBy(f => f).ToArray();
        var res = people.Select(p =>
        {
            // have started
            var s = GetUpperBound(start, p);

            // have ended
            var e = GetUpperBound(end, p);

            return s - e;
        }).ToArray();
        return res;
    }

    private static int GetUpperBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (arr[m] <= target)
                l = m + 1;
            else
                r = m;
        }
        return l;
    }
}
