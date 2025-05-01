namespace playground;

public class _3238_WinningPlayerCount
{
    public static int WinningPlayerCount(int n, int[][] pick)
    {
        int res = 0;
        var memo = new int[n, 11];
        foreach (var p in pick)
        {
            memo[p[0], p[1]]++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (memo[i, j] > i)
                {
                    res++;
                    break;
                }
            }
        }
        return res;
    }
}
