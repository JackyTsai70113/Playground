namespace playground._3400_3499;

public class _3494_MinTime
{
    public static long MinTime(int[] skill, int[] mana)
    {
        int m = mana.Length, n = skill.Length;
        var memo = new long[n + 1];
        long presum = 0;
        for (int i = 0; i < m; i++)
        {
            memo[0] = memo[1] + presum;
            long tempPresum = 0;
            for (int j = 1; j < n + 1; j++)
            {
                long cur = memo[j - 1] + skill[j - 1] * mana[i];
                if (j + 1 < n + 1 && cur < memo[j + 1] + presum)
                {
                    tempPresum = Math.Max(tempPresum, memo[j + 1] + presum - cur);
                }
                memo[j] = memo[j - 1] + skill[j - 1] * mana[i];
            }
            presum = tempPresum;
        }
        return memo[^1] + presum;
    }
}
