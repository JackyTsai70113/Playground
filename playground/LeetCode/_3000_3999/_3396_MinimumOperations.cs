namespace playground.LeetCode._3000_3999;

public class _3396_MinimumOperations
{
    public static int MinimumOperations(int[] nums)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in nums)
            d[num] = d.GetValueOrDefault(num) + 1;
        int op = 0;
        while (true)
        {
            if (d.Keys.Count == Math.Max(0, nums.Length - op * 3))
            {
                break;
            }
            for (int j = 0; j < 3 && op * 3 + j < nums.Length; j++)
            {
                d[nums[op * 3 + j]]--;
                if (d[nums[op * 3 + j]] == 0)
                    d.Remove(nums[op * 3 + j]);

            }
            op++;
        }
        return op;
    }
}
