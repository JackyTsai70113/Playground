namespace playground.TwoPointers;

public class NumSubseqClass
{
    /// <remarks>https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/</remarks>
    public static int NumSubseq(int[] nums, int target)
    {
        int n = nums.Length, MOD = (int)(1e9 + 7);
        Array.Sort(nums);

        var pow = new int[n];
        for (int i = 0; i < n; i++)
        {
            pow[i] = i == 0 ? 1 : (pow[i - 1] * 2) % MOD;
        }

        long res = 0;
        for (int i = 0; i < n; ++i)
        {
            int index = Array.BinarySearch(nums, target - nums[i]);
            if (index < 0) index = ~index;
            while (index < n && nums[index] == target - nums[i]) index++;
            if (index >= i)
            {
                res = (res + (index == i ? 0 : pow[index - i - 1])) % MOD;
            }
        }
        return (int)res;
    }
}
