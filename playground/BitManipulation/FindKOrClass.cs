namespace playground.BitManipulation;

public class FindKOrClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-k-or-of-an-array
    /// </summary>
    public static int FindKOr(int[] nums, int k)
    {
        var res = 0;
        for (int j = 0; j < 32; ++j)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if ((nums[i] & (1 << j)) > 0)
                {
                    count++;
                    if (count >= k)
                        break;
                }
            }
            if (count >= k)
            {
                res |= 1 << j;
            }
        }
        return res;
    }
}
