namespace playground.Arrays;

public class MatrixSumClass
{
    /// <remarks>https://leetcode.com/problems/sum-in-a-matrix</remarks>
    public static int MatrixSum(int[][] nums)
    {
        int m = nums.Length, n = nums[0].Length;
        for (int i = 0; i < m; ++i)
        {
            Array.Sort(nums[i]);
        }
        var res = 0;
        for (int i = 0; i < n; ++i)
        {
            var max = 0;
            for (int j = 0; j < m; ++j)
            {
                max = Math.Max(max, nums[j][i]);
            }
            res += max;
        }
        return res;
    }
}
