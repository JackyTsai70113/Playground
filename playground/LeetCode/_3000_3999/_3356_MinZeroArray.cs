namespace playground.LeetCode._3000_3999;

public class _3356_MinZeroArray
{
    public static int MinZeroArray(int[] nums, int[][] queries)
    {
        if (nums.All(x => x == 0)) return 0;
        int num_len = nums.Length, query_len = queries.Length;
        int l = 0, r = query_len;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (IsValid(nums, queries, m))
                r = m;
            else
                l = m + 1;
        }
        return l == query_len ? -1 : l + 1;
    }

    static bool IsValid(int[] nums, int[][] queries, int k)
    {
        int num_len = nums.Length;
        var prefix = new int[num_len + 1];
        for (int i = 0; i <= k; i++)
        {
            prefix[queries[i][0]] += queries[i][2];
            prefix[queries[i][1] + 1] -= queries[i][2];
        }
        int cur_val = 0;
        for (int j = 0; j < num_len; j++)
        {
            cur_val += prefix[j];
            if (nums[j] - cur_val > 0)
            {
                return false;
            }
        }
        return true;
    }
}
