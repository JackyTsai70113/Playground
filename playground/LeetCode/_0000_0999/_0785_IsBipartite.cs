namespace playground.LeetCode._0000_0999;

public class _0785_IsBipartite
{
    public static bool IsBipartite(int[][] g)
    {
        int n = g.Length;
        var colors = new int[n];
        Array.Fill(colors, -1);
        bool dfs(int u)
        {
            foreach (var v in g[u])
            {
                if (colors[v] == -1)
                {
                    colors[v] = 1 - colors[u];
                    if (!dfs(v))
                        return false;
                }
                else if (colors[v] == colors[u])
                {
                    return false;
                }
            }
            return true;
        }
        for (int i = 0; i < n; i++)
        {
            if (colors[i] == -1)
            {
                colors[i] = 0;
                if (!dfs(i))
                    return false;
            }
        }
        return true;
    }
}
