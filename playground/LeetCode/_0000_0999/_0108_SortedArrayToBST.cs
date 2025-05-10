using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0108_SortedArrayToBST
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
    /// </summary>
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return Dfs(nums, 0, nums.Length - 1);
    }
    public static TreeNode Dfs(int[] nums, int l, int r)
    {
        if (l > r)
            return null;
        if (l == r)
            return new TreeNode(nums[l]);
        int m = l + (r - l) / 2;
        return new TreeNode(nums[m],
            Dfs(nums, l, m - 1),
            Dfs(nums, m + 1, r));
    }
}
