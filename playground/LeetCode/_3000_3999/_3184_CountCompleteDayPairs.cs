namespace playground.LeetCode._3000_3999;

public class _3184_CountCompleteDayPairs
{
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
