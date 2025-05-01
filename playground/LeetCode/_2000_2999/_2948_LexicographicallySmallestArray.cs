namespace playground.LeetCode._2000_2999;

public class _2948_LexicographicallySmallestArray
{
    /// <summary>
    /// https://leetcode.com/problems/make-lexicographically-smallest-array-by-swapping-elements
    /// </summary>
    public static int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        var arr = nums
            .Select((x, i) => new int[] { x, i })
            .OrderBy(y => y[0])
            .ToArray();
        var res = new int[nums.Length];
        var l = new List<int[]>();
        for (int i = 0; i <= arr.Length; ++i)
        {
            if (i == arr.Length || l.Count > 0 && arr[i][0] - l[^1][0] > limit)
            {
                var a = l.Select(y => y[1]).OrderBy(x => x).ToArray();
                for (int j = 0; j < a.Length; j++)
                {
                    res[a[j]] = l[j][0];
                }
                l = new();
            }
            if (i < arr.Length)
                l.Add(arr[i]);
        }
        return res;
    }
}
