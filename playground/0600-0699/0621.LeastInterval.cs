namespace playground;

public class LeastInterval0621
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
        if (maxCount >= n + 1)
            return m;
        var other = Math.Max((n + 1 - maxCount) * (max - 1), m - max * maxCount);
        return max * maxCount + other;
    }
}
