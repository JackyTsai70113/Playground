namespace playground.LeetCode._2000_2999;

public class _2924_FindChampion
{
    /// <summary>
    /// https://leetcode.com/problems/find-champion-ii
    /// </summary>
    public static int FindChampion(int n, int[][] edges)
    {
        var s = Enumerable.Range(0, n).ToHashSet();
        foreach (var e in edges)
        {
            s.Remove(e[1]);
        }
        return s.Count == 1 ? s.First() : -1;
    }
}
