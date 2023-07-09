namespace playground.Arrays;

public class CheckArrayClass
{
    /// <summary>
    /// https://leetcode.com/problems/apply-operations-to-make-all-array-elements-equal-to-zero
    /// </summary>
    public static bool CheckArray(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
                continue;
            int j = i;
            int a = nums[i];
            for (; j < i + k; j++)
            {
                if (j == nums.Length)
                    return false;
                nums[j] -= a;
                if (nums[j] < 0)
                    return false;
            }
        }
        return true;
    }
}
