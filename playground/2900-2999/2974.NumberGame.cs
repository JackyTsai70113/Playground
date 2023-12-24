namespace playground;

public class NumberGame2974
{
    // https://leetcode.com/problems/minimum-number-game
    public static int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i + 1 < nums.Length; i += 2)
        {
            (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
        }
        return nums;
    }
}
