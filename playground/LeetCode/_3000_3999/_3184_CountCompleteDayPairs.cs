namespace playground;

public class _3184_CountCompleteDayPairs
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-that-form-a-complete-day-i
    /// </summary>
    public static int CountCompleteDayPairs(int[] hours)
    {
        var res = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            for (int j = i + 1; j < hours.Length; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0)
                    res++;
            }
        }
        return res;
    }
}
