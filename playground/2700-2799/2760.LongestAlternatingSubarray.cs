namespace playground;

public class LongestAlternatingSubarray_2760
{
    public static int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        int n = nums.Length, res = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            int a = 0;
            int j = i;
            while (j < n && nums[j] <= threshold && (nums[j] & 1 ^ a) == 0)
            {
                res = Math.Max(res, j - i + 1);
                j++;
                a ^= 1;
            }
            if (i != j) i = j - 1;
        }
        return res;
    }
}
