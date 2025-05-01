namespace playground._3300_3399;

public class _3354_CountValidSelections
{
    public static int CountValidSelections(int[] nums)
    {
        int sum = nums.Sum(), res = 0;
        for (int i = 0, cur = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (cur * 2 == sum)
                    res += 2;
                else if (cur * 2 + 1 == sum || cur * 2 - 1 == sum)
                    res++;
            }
            else
            {
                cur += nums[i];
            }
        }
        return res;
    }
}
