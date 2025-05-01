namespace playground;

public class _1248_NumberOfSubarrays_cs
{
    public static int NumberOfSubarrays(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        bool Valid()
        {
            return k >= 0;
        }
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            if (nums[r] % 2 == 1)
                k--;
            while (!Valid())
            {
                // update state by A[l]
                if (nums[l] % 2 == 1)
                    k++;
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}
