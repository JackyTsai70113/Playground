namespace playground;

public class NumberOfPatterns0351
{
    public static int NumberOfPatterns(int m, int n)
    {
        int[,] skip = new int[10, 10];
        skip[1, 3] = skip[3, 1] = 2;
        skip[1, 7] = skip[7, 1] = 4;
        skip[3, 9] = skip[9, 3] = 6;
        skip[7, 9] = skip[9, 7] = 8;
        skip[1, 9] = skip[9, 1] = skip[2, 8] = skip[8, 2] = 5;
        skip[3, 7] = skip[7, 3] = skip[4, 6] = skip[6, 4] = 5;

        var seen = new bool[10];
        int res = 0;
        res += (Dfs(n, 1, seen, skip) - Dfs(m - 1, 1, seen, skip)) * 4;
        res += (Dfs(n, 2, seen, skip) - Dfs(m - 1, 2, seen, skip)) * 4;
        res += Dfs(n, 5, seen, skip) - Dfs(m - 1, 5, seen, skip);
        return res;
    }

    static int Dfs(int step, int cur, bool[] seen, int[,] skip)
    {
        if (step == 0 || seen[cur]) return 0;
        if (step == 1) return 1;
        seen[cur] = true;
        int res = 1;
        for (int i = 1; i <= 9; i++)
        {
            if (seen[i] || skip[cur, i] != 0 && !seen[skip[cur, i]])
                continue;
            res += Dfs(step - 1, i, seen, skip);
        }
        seen[cur] = false;
        return res;
    }
}
