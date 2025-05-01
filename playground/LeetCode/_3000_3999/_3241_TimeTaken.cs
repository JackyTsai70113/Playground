namespace playground;

public class _3241_TimeTaken
{
    public static int[] TimeTaken(int[][] edges)
    {
        int n = edges.Length + 1;
        int[] nodeParent = new int[n];
        List<int>[] graph = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            nodeParent[i] = -1;
            graph[i] = new();
        }
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }
        var dists = new List<(int v, int d)>[n];
        for (int i = 0; i < n; i++)
        {
            dists[i] = new List<(int, int)>{
                (-1,0),
                (-1,0)
            };
        }
        // maximum distance of u to other v
        int Dfs(int par, int u)
        {
            nodeParent[u] = par;
            int maxDist = 0;
            foreach (var v in graph[u])
            {
                if (v == par) continue;
                int curDist = Dfs(u, v);
                curDist += (v & 1) > 0 ? 1 : 2;
                if (dists[u][0].d <= curDist)
                {
                    dists[u][1] = dists[u][0];
                    dists[u][0] = (v, curDist);
                }
                else if (dists[u][1].d < curDist)
                {
                    dists[u][1] = (v, curDist);
                }
                maxDist = Math.Max(maxDist, curDist);
            }
            return maxDist;
        }
        Dfs(-1, 0);
        var res = new int[n];
        res[0] = dists[0][0].d;
        for (int i = 1; i < n; i++)
        {
            int curDist;
            if (dists[nodeParent[i]][0].v != i)
            {
                curDist = dists[nodeParent[i]][0].d + ((nodeParent[i] & 1) > 0 ? 1 : 2);
            }
            else
            {
                curDist = dists[nodeParent[i]][1].d + ((nodeParent[i] & 1) > 0 ? 1 : 2);
            }
            if (dists[i][0].d <= curDist)
            {
                dists[i][1] = dists[i][0];
                dists[i][0] = (nodeParent[i], curDist);
            }
            else if (dists[i][1].d < curDist)
            {
                dists[i][1] = (nodeParent[i], curDist);
            }
            res[i] = dists[i][0].d;
        }
        return res;
    }
}
