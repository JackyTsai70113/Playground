namespace playground;

public class MoveZeroes0283
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes
    /// </summary>
    public void MoveZeroes(int[] nums)
    {
        int l = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            if(nums[r] == 0) continue;
            nums[l++] = nums[r];
        }
        for (; l < nums.Length; l++)
        {
            nums[l] = 0;
        }
    }
}
