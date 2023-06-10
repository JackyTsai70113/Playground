namespace playground.Arrays;

public class SemiOrderedPermutationClass
{
    /// <summary>
    /// https://leetcode.com/problems/semi-ordered-permutation
    /// </summary>
    public static int SemiOrderedPermutation(int[] nums)
    {
        int l = Array.IndexOf(nums, 1), r = Array.IndexOf(nums, nums.Length);
        if (l > r)
        {
            return 2 * (l - r) - 1 + r + nums.Length - 1 - l;
        }
        else
        {
            return l + nums.Length - 1 - r;
        }
    }
}
