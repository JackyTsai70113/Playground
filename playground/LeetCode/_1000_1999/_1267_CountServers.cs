namespace playground.LeetCode._1000_1999;

public class _1267_CountServers
{
    public static int CountServers(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        var adj = new Dictionary<(int, int), List<(int, int)>>();
        for (int i = 0; i < m; i++)
        {
            List<(int r, int c)> servers = new();
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    adj[(i, j)] = new();
                    servers.Add((i, j));
                }
            }

            for (int k = 0; k < servers.Count; k++)
            {
                for (int l = k + 1; l < servers.Count; l++)
                {
                    adj[(servers[k].r, servers[k].c)].Add((servers[l].r, servers[l].c));
                    adj[(servers[l].r, servers[l].c)].Add((servers[k].r, servers[k].c));
                }
            }
        }
        for (int j = 0; j < n; j++)
        {
            List<(int r, int c)> servers = new();
            for (int i = 0; i < m; i++)
            {
                if (A[i][j] == 1)
                {
                    servers.Add((i, j));
                }
            }

            for (int k = 0; k < servers.Count; k++)
            {
                for (int l = k + 1; l < servers.Count; l++)
                {
                    adj[(servers[k].r, servers[k].c)].Add((servers[l].r, servers[l].c));
                    adj[(servers[l].r, servers[l].c)].Add((servers[k].r, servers[k].c));
                }
            }
        }

        int Dfs(int i, int j)
        {
            if (A[i][j] != 1)
                return 0;
            A[i][j] = 0;
            int res = 1;
            foreach (var (r, c) in adj[(i, j)])
                res += Dfs(r, c);
            return res;
        }


        int res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i][j] == 1)
                {
                    int count = Dfs(i, j);
                    if (count > 1)
                    {
                        res += count;
                    }
                }
            }
        }
        return res;
    }
}
