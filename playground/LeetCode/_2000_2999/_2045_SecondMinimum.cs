namespace playground.LeetCode._2000_2999;

public class _2045_SecondMinimum
{
    public static int SecondMinimum(int n, int[][] edges, int time, int change)
    {
        var graph = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++) graph[i] = new();
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        int[] dist1 = new int[n + 1];
        int[] dist2 = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            dist1[i] = -1;
            dist2[i] = -1;
        }

        Queue<(int u, int d)> q = new();
        q.Enqueue((1, 1));
        dist1[1] = 0;
        int res = 0;
        while (res == 0 && q.Count > 0)
        {
            var (u, freq) = q.Dequeue();
            int timeTaken = freq == 1 ? dist1[u] : dist2[u];
            if ((timeTaken / change) % 2 == 1)
            {
                timeTaken = change * (timeTaken / change + 1) + time;
            }
            else
            {
                timeTaken = timeTaken + time;
            }

            foreach (var v in graph[u])
            {
                if (dist1[v] == -1)
                {
                    dist1[v] = timeTaken;
                    q.Enqueue((v, 1));
                }
                else if (dist2[v] == -1 && dist1[v] != timeTaken)
                {
                    if (v == n)
                    {
                        res = timeTaken;
                        break;
                    }
                    dist2[v] = timeTaken;
                    q.Enqueue((v, 2));
                }
            }
        }
        return res;
    }
}
