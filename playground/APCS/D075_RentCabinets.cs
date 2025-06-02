namespace playground.APCS;

public class D075_RentCabinets
{
    /// <summary>
    /// https://judge.tcirc.tw/problem/d075
    /// /// </summary>
    public static int RentCabinets(int M, int S, int[] spaces)
    {
        int sum = spaces.Sum();
        int remaining = M - sum;
        if (remaining >= S)
            return 0;
        int res = int.MaxValue;
        var dp = new bool[S - remaining];
        dp[0] = true;
        foreach (var s in spaces)
        {
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                if (dp[i])
                {
                    if (i + s < dp.Length)
                    {
                        dp[i + s] = true;
                    }
                    else
                    {
                        res = Math.Min(res, i + s);
                    }
                }
            }
        }
        return res;
    }
}
