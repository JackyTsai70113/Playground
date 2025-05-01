namespace playground.LeetCode._0000_0999;

public class _0532_FindPairs
{
    /// <summary>
    /// https://leetcode.com/problems/k-diff-pairs-in-an-array
    /// </summary>
    /// <remarks>
    /// O(N)/O(N)
    /// </remarks>
    public static int FindPairs(int[] nums, int k)
    {
        var d = new Dictionary<int, int>();
        int res = 0;
        foreach (var num in nums)
        {
            if (k == 0)
            {
                if (d.ContainsKey(num) && d[num] == 1)
                    res++;
            }
            else
            {
                if (d.ContainsKey(num)) continue;
                if (d.ContainsKey(num - k)) res++;
                if (d.ContainsKey(num + k)) res++;
            }
            d[num] = d.ContainsKey(num) ? d[num] + 1 : 1;
        }
        return res;
    }

    /// <remarks>
    /// O(NlogN)/O(1)
    /// </remarks>
    public static int FindPairs2(int[] nums, int k)
    {
        Array.Sort(nums);
        int n = nums.Length, res = 0;
        for (int l = 0, r = 0; r < n; r++)
        {
            while (r + 1 < n && nums[r] == nums[r + 1]) r++;
            while (nums[l] + k < nums[r]) l++;
            if (l != r && nums[l] + k == nums[r]) res++;
        }
        return res;
    }
}
