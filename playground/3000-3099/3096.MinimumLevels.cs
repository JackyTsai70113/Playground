namespace playground;

public class MinimumLevels3096
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-levels-to-gain-more-points
    /// </summary>
    public static int MinimumLevels(int[] possible)
    {
        var sum = 0;
        for (int i = 0; i < possible.Length; i++)
        {
            sum += possible[i] == 1 ? 1 : -1;
        }
        for (int i = 0, cur = 0; i < possible.Length - 1; i++)
        {
            cur += possible[i] == 1 ? 1 : -1;
            if (cur > sum - cur)
            {
                return i + 1;
            }
        }
        return -1;
    }
}
