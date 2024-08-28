namespace playground;

public class NumberOfPatterns0351
{
    public static int NumberOfPatterns(int m, int n)
    {
        return Helper(n) - Helper(m - 1);
    }

    static int Helper(int n)
    {
        if (n == 0) return 0;
        int res = 0;
        bool[] seen;
        for (int i = 1; i <= 9; i++)
        {
            seen = new bool[10];
            res += Dfs(n, i, seen, new int[n + 1, 10, 1 << 9]);
        }
        return res;
    }
    static int Dfs(int step, int cur, bool[] seen, int[,,] dp)
    {
        if (step == 0 || seen[cur]) return 0;
        if (step == 1) return 1;
        seen[cur] = true;
        int num = ToInt(seen);
        if (dp[step, cur, num] != 0)
            return dp[step, cur, num];
        int res = 1;
        for (int i = 1; i <= 9; i++)
        {
            if (seen[i])
                continue;
            if (!IsValid(cur, i, seen))
                continue;
            res += Dfs(step - 1, i, seen, dp);
        }
        seen[cur] = false;
        return dp[step, cur, num] = res;
    }

    static bool IsValid(int start, int end, bool[] seen)
    {
        if (start > end)
            return IsValid(end, start, seen);
        var dirs = new int[][]{
            new int[]{ 1,2,3 },
            new int[]{ 4,5,6 },
            new int[]{ 7,8,9 },
            new int[]{ 1,4,7 },
            new int[]{ 2,5,8 },
            new int[]{ 3,6,9 },
            new int[]{ 1,5,9 },
            new int[]{ 3,5,7 },
        };
        for (int i = 0; i < dirs.Length; i++)
        {
            if (start == dirs[i][0] && end == dirs[i][2])
                return seen[dirs[i][1]] == false;
        }
        return true;
    }

    static int ToInt(bool[] seen)
    {
        int res = 0;
        for (int i = 1; i <= 9; i++)
        {
            res |= seen[i] ? 1 : 0;
        }
        return res;
    }
}
