namespace playground;

public class _3074_MinimumBoxes
{
    /// <summary>
    /// https://leetcode.com/problems/apple-redistribution-into-boxes/
    /// </summary>
    public static int MinimumBoxes(int[] apple, int[] capacity)
    {
        Array.Sort(capacity);
        int res = 0, cur = 0, sum = apple.Sum();
        for (int i = capacity.Length - 1; i >= 0; i--)
        {
            cur += capacity[i];
            res++;
            if (cur >= sum)
            {
                break;
            }
        }
        return res;
    }
}
