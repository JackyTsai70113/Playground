namespace playground;

public class Solution
{
    /// <remarks>https://leetcode.com/problems/make-costs-of-paths-equal-in-a-binary-tree/</remarks>
    public static int MinIncrements(int n, int[] cost)
    {
        var res = 0;
        for (int i = n - 1; i > 0; i -= 2)
        {
            int max = Math.Max(cost[i - 1], cost[i]);
            res += max * 2 - cost[i - 1] - cost[i];
            cost[(i >> 1) - 1] += max;
        }
        return res;
    }

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

    /// <remarks>https://leetcode.com/problems/find-the-distinct-difference-array/</remarks>
    public static int[] DistinctDifferenceArray(int[] nums)
    {
        var s = new HashSet<int>();
        var d2 = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            d2[num] = d2.ContainsKey(num) ? d2[num] + 1 : 1;
        }

        var res = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
        {
            s.Add(nums[i]);
            if (--d2[nums[i]] == 0) d2.Remove(nums[i]);
            res[i] = s.Count - d2.Keys.Count;
        }
        return res;
    }
}
