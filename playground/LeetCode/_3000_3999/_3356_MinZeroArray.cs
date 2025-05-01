namespace playground._3300_3399;

public class _3356_MinZeroArray
{
    public static int MinZeroArray(int[] nums, int[][] queries)
    {
        bool valid = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                valid = false;
                break;
            }
        }
        if (valid) return 0;

        int l = 0, r = queries.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (Valid(nums, queries, m))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l == queries.Length ? -1 : l + 1;
    }

    public static bool Valid(int[] nums, int[][] queries, int m)
    {
        var A = new int[nums.Length];
        for (int i = 0; i <= m; i++)
        {
            A[queries[i][0]] += queries[i][2];
            if (queries[i][1] < nums.Length - 1)
                A[queries[i][1] + 1] -= queries[i][2];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0)
            {
                A[i] += A[i - 1];
            }
            if (A[i] < nums[i])
            {
                return false;
            }
        }
        return true;
    }
}
