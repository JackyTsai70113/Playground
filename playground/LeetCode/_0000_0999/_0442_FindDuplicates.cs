namespace playground.LeetCode._0000_0999;

public class _0442_FindDuplicates
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-duplicates-in-an-array
    /// </summary>
    public static IList<int> FindDuplicates(int[] nums)
    {
        var res = new List<int>();
        foreach (var num in nums)
        {
            var index = Math.Abs(num) - 1;
            if (nums[index] < 0)
            {
                res.Add(index + 1);
            }
            else
            {
                nums[index] = -nums[index];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Math.Abs(nums[i]);
        }
        return res;
    }
}
