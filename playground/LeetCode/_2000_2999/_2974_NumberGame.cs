namespace playground.LeetCode._2000_2999;

public class _2974_NumberGame
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
