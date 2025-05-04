namespace playground.LeetCode._3000_3999;

public class _3537_SpecialGrid
{
    public static int[][] SpecialGrid(int N)
    {
        int n = (int)Math.Pow(2, N);
        var res = new int[n][];
        for (int i = 0; i < n; i++)
            res[i] = new int[n];
        Helper(res, 0, 0, n, n, 0, n * n);
        return res;
    }

    static void Helper(int[][] res, int x1, int y1, int x2, int y2, int v1, int v2)
    {
        if (x1 + 1 == x2 && y1 + 1 == y2)
        {
            res[x1][y1] = v1;
            return;
        }

        int midX = (x1 + x2) / 2;
        int midY = (y1 + y2) / 2;
        Helper(res, x1, midY, midX, y2, v1, v1 + (v2 - v1) / 4);
        Helper(res, midX, midY, x2, y2, v1 + (v2 - v1) / 4, v1 + 2 * (v2 - v1) / 4);
        Helper(res, midX, y1, x2, midY, v1 + 2 * (v2 - v1) / 4, v1 + 3 * (v2 - v1) / 4);
        Helper(res, x1, y1, midX, midY, v1 + 3 * (v2 - v1) / 4, v2);
    }
}
