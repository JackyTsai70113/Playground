namespace playground.DynamicPrograming;

public class UniquePathsClass
{
    public static int UniquePaths(int m, int n)
    {
        int nn = m + n - 2, kk = Math.Max(m - 1, n - 1);
        long res = 1;
        for (int i = nn; i > kk; i--)
            res = res * i / (nn - i + 1);
        return (int)res;
    }
}
