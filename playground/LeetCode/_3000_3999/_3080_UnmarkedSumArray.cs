namespace playground;

public class _3080_UnmarkedSumArray
{
    /// <summary>
    /// https://leetcode.com/problems/mark-elements-on-array-by-performing-queries/
    /// </summary>
    public static long[] UnmarkedSumArray(int[] nums, int[][] queries)
    {
        var arr = nums.Select((x, i) => i).ToArray();
        Array.Sort(arr, (i1, i2) =>
        {
            if (nums[i1] != nums[i2])
                return nums[i1] - nums[i2];
            return i1 - i2;
        });

        int n = nums.Length;
        var res = new long[queries.Length];
        long sum = 0;
        for (int i = 0; i < n; i++)
            sum += nums[i];

        for (int i = 0, j = 0; i < queries.Length && j < n; i++)
        {
            var (index, k) = (queries[i][0], queries[i][1]);
            sum -= nums[index];
            nums[index] = 0;
            while (k > 0 && j < n)
            {
                if (nums[arr[j]] > 0)
                {
                    sum -= nums[arr[j]];
                    nums[arr[j]] = 0;
                    k--;
                }
                j++;
            }
            res[i] = sum;
        }
        return res;
    }
}
