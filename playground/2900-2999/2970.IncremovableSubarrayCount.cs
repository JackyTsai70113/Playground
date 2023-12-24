namespace playground;

public class IncremovableSubarrayCount2970
{
    // https://leetcode.com/problems/count-the-number-of-incremovable-subarrays-i
    public static int IncremovableSubarrayCount(int[] nums)
    {
        int n = nums.Length, res = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                bool incre = true;
                for (int k = 1; incre && k < i; k++)
                {
                    if (nums[k - 1] >= nums[k])
                    {
                        incre = false;
                    }
                }
                if (i - 1 >= 0 && j + 1 < n && nums[i - 1] >= nums[j + 1])
                    incre = false;
                for (int k = j + 2; incre && k < n; k++)
                {
                    if (nums[k - 1] >= nums[k])
                    {
                        incre = false;
                    }
                }
                if (incre)
                    res++;
            }
        }
        return res;
    }
}
