namespace playground.LeetCode._3000_3999;

public class _3254_ResultsArray
{
    public static int[] ResultsArray(int[] nums, int k)
    {
        int count = 0;
        var res = new int[nums.Length - k + 1];
        for (int r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            if (r == 0 || nums[r - 1] + 1 == nums[r])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (r >= k - 1)
            {
                res[r - k + 1] = count >= k ? nums[r] : -1;
                // update state by A[l]
            }
        }
        return res;
    }
}
