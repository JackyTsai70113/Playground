namespace playground.LeetCode._0000_0999;

public class _0621_LeastInterval
{
    public static int LeastInterval(char[] tasks, int n)
    {
        int max = 0, maxCount = 0, m = tasks.Length;
        int[] counts = new int[26];
        foreach (var t in tasks)
        {
            counts[t - 'A']++;
            if (counts[t - 'A'] > max)
            {
                max = counts[t - 'A'];
                maxCount = 1;
            }
            else if (counts[t - 'A'] == max)
            {
                maxCount++;
            }
        }
        return Math.Max((n + 1) * (max - 1) + maxCount, m);
    }
}
