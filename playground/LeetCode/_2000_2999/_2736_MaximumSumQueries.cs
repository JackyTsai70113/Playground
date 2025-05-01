namespace playground.LeetCode._2000_2999;

public class _2736_MaximumSumQueries
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-queries
    /// </summary>
    public static int[] MaximumSumQueries(int[] nums1, int[] nums2, int[][] queries)
    {
        SortedDictionary<int, List<int>> sd = new(Comparer<int>.Create((x, y) => y - x));
        for (int i = 0; i < nums1.Length; i++)
        {
            int sum = nums1[i] + nums2[i];
            if (!sd.ContainsKey(sum))
                sd[sum] = new();
            sd[sum].Add(nums1[i]);
        }

        foreach (var sum in sd.Keys)
        {
            sd[sum].Sort();
        }

        var res = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int x = queries[i][0], y = queries[i][1];
            res[i] = -1;
            foreach (var sum in sd.Keys)
            {
                if (sum < x + y)
                    break;
                int l = 0, r = sd[sum].Count;
                while (l < r)
                {
                    int m = l + (r - l) / 2;
                    if (sd[sum][m] >= x) r = m;
                    else l = m + 1;
                }
                if (l < sd[sum].Count && sum - sd[sum][l] >= y)
                {
                    res[i] = sum;
                    break;
                }
            }
        }
        return res;
    }
}
