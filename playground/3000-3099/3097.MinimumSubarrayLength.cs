namespace playground;

public class MinimumSubarrayLength3097
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-subarray-with-or-at-least-k-ii
    /// </summary>
    public static int MinimumSubarrayLength(int[] nums, int k)
    {
        if (k == 0) return 1;
        int res = int.MaxValue;
        var bits = new int[32];
        int curNum()
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                if (bits[i] > 0) res |= 1 << i;
            }
            return res;
        }
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // add nums[r] to bits
            int rightNum = nums[r];
            for (int i = 0; rightNum > 0; i++)
            {
                bits[i] += rightNum & 1;
                rightNum >>= 1;
            }

            while (curNum() >= k)
            {
                res = Math.Min(res, r - l + 1);
                // remove nums[l] to bits
                int leftNum = nums[l];
                for (int i = 0; leftNum > 0; i++)
                {
                    bits[i] -= leftNum & 1;
                    leftNum >>= 1;
                }
                l++;
            }
        }
        return res == int.MaxValue ? -1 : res;
    }
}
