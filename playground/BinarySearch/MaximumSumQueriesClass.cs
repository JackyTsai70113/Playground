namespace playground.BinarySearch;

public class MaximumSumQueriesClass
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
                int index = Array.BinarySearch(sd[sum].ToArray(), x);
                if (index < 0)
                    index = ~index;
                if (index < sd[sum].Count && sum - sd[sum][index] >= y)
                {
                    res[i] = sum;
                    break;
                }
            }
        }
        return res;
    }
}