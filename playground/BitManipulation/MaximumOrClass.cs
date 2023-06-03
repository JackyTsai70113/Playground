namespace playground.BitManipulation;

public class MaximumOrClass
{
    public static long MaximumOr(int[] nums, int k)
    {
        int n = nums.Length, left = 0;
        int[] right = new int[n];
        for (int i = n - 2; i >= 0; --i)
            right[i] = right[i + 1] | nums[i + 1];
        long res = 0;
        for (int i = 0; i < n; i++)
        {
            res = Math.Max(res, ((uint)left) | ((long)nums[i] << k) | ((uint)right[i]));
            left |= nums[i];
        }
        return res;
    }
}
