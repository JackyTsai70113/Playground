namespace playground.LeetCode._1000_1999;

public class _1014_MaxScoreSightseeingPair
{
    public static int MaxScoreSightseeingPair(int[] values)
    {
        int max = values[0], res = int.MinValue;
        for (int i = 1; i < values.Length; i++)
        {
            res = Math.Max(res, max + values[i] - i);
            max = Math.Max(max, values[i] + i);
        }
        return res;
    }
}
