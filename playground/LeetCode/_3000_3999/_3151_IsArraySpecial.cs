namespace playground;

public class _3151_IsArraySpecial
{
    /// <summary>
    /// https://leetcode.com/problems/special-array-i
    /// </summary>
    public static bool IsArraySpecial(int[] nums)
    {
        var res = true;
        for (int i = 1; i < nums.Length; i++)
        {
            if (((nums[i - 1] & 1) ^ (nums[i] & 1)) == 0)
                return false;
        }
        return res;
    }
}
