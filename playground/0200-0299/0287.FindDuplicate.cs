namespace playground;

public class FindDuplicate0287
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number
    /// </summary>
    public static int FindDuplicate(int[] nums)
    {
        var res = -1;
        foreach(var num in nums)
        {
            var index = Math.Abs(num) - 1;
            if (nums[index] < 0)
            {
                res = index+1;
                break;
            }
            nums[index] = -nums[index];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Math.Abs(nums[i]);
        }
        return res;
    }
}
