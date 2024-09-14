namespace playground;

public class LongestSubarray2419
{
    public static int LongestSubarray(int[] nums)
    {
        int max = 0, curLen = 1, maxLen = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                curLen = 1;
                maxLen = 1;
            }
            else if (nums[i] == max)
            {
                curLen++;
                maxLen = Math.Max(maxLen, curLen);
            }
            else
            {
                curLen = 0;
            }
        }
        return maxLen;
    }
}
