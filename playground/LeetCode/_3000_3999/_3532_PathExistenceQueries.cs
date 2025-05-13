namespace playground.LeetCode._3000_3999;

public class _3532_PathExistenceQueries
{
    public static bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
    {
        var ds = new DisjointSet(n);
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(nums[i] - nums[i - 1]) <= maxDiff)
            {
                ds.Join(i - 1, i);
            }
        }

        var res = new bool[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            if (ds.Find(queries[i][0]) == ds.Find(queries[i][1]))
            {
                res[i] = true;
            }
        }
        return res;
    }
}
