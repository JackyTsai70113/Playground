namespace playground;

public class _3117_MinimumValueSum
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-sum-of-values-by-dividing-array
    /// </summary>
    public static int MinimumValueSum(int[] nums, int[] andValues)
    {
        var memo = new Dictionary<int, int>[nums.Length, andValues.Length];
        var res = Dfs(nums, andValues, 0, 0, (1 << 17) - 1, memo);
        return res == int.MaxValue ? -1 : res;
    }

    private static int Dfs(int[] nums, int[] andValues, int i, int j, int andValue, Dictionary<int, int>[,] memo)
    {
        if (j == andValues.Length && i == nums.Length) return 0;
        if (j == andValues.Length || i == nums.Length) return int.MaxValue;
        if (memo[i, j] != null && memo[i, j].ContainsKey(andValue)) return memo[i, j][andValue];
        if (memo[i, j] == null) memo[i, j] = new();
        var newAndValue = andValue & nums[i];
        if (newAndValue == andValues[j])
        {
            int include = Dfs(nums, andValues, i + 1, j, newAndValue, memo);
            int exclude = Dfs(nums, andValues, i + 1, j + 1, (1 << 17) - 1, memo);
            if (exclude == int.MaxValue)
                memo[i, j][andValue] = include;
            else
                memo[i, j][andValue] = Math.Min(include, nums[i] + exclude);
        }
        else if (newAndValue < andValues[j])
        {
            memo[i, j][andValue] = int.MaxValue;
        }
        else
        {
            memo[i, j][andValue] = Dfs(nums, andValues, i + 1, j, newAndValue, memo);
        }
        return memo[i, j][andValue];
    }
}
