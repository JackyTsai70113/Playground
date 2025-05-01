namespace playground.LeetCode._2000_2999;

public class _2908_MinimumSum
{
    public static int MinimumSum(int[] nums)
    {
        int n = nums.Length;
        var leftMin = new int[n];
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            leftMin[i] = min;
            min = Math.Min(min, nums[i]);
        }

        var rightMin = new int[n];
        min = int.MaxValue;
        for (int i = n - 1; i >= 0; i--)
        {
            rightMin[i] = min;
            min = Math.Min(min, nums[i]);
        }

        var res = int.MaxValue;
        for (int i = 1; i < n - 1; i++)
        {
            if (leftMin[i] < nums[i] && rightMin[i] < nums[i])
                res = Math.Min(res, leftMin[i] + nums[i] + rightMin[i]);
        }
        return res == int.MaxValue ? -1 : res;
    }
}
