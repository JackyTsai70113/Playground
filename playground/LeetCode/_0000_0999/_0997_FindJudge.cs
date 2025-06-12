namespace playground.LeetCode._0000_0999;

public class _0997_FindJudge
{
    public static int FindJudge(int n, int[][] trust)
    {
        var indegree = new int[n + 1];
        foreach (var t in trust)
        {
            indegree[t[0]]--;
            indegree[t[1]]++;
        }
        for (int i = 1; i <= n; i++)
        {
            if (indegree[i] == n - 1)
                return i;
        }
        return -1;
    }
}
