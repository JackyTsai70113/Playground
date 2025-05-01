namespace playground.LeetCode._0000_0999;

public class _0015_ThreeSum
{
    /// <summary>
    /// https://leetcode.com/problems/3sum
    /// </summary>
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;
        var res = new List<IList<int>>();
        for (int i = 0; i < n && nums[i] <= 0; ++i)
        {
            int l = i + 1, r = n - 1;
            while (l < r)
            {
                if (nums[i] + nums[l] + nums[r] < 0) l++;
                else if (nums[i] + nums[l] + nums[r] > 0) r--;
                else
                {
                    var list = new int[] { nums[i], nums[l], nums[r] };
                    res.Add(list);
                    while (l < r && nums[l] == list[1]) l++;
                    while (l < r && nums[r] == list[2]) r--;
                }
            }
            while (i < n - 1 && nums[i] == nums[i + 1]) i++;
        }
        return res;
    }
}
