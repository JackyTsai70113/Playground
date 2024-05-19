namespace playground.DynamicPrograming;

public class Knapsack
{
    /// <summary>
    /// https://leetcode.com/problems/painting-the-walls
    /// </summary> 
    /// <remarks>0/1 Knapsack</remarks>
    public static int PaintWalls(int[] cost, int[] time)
    {
        int n = cost.Length;
        var memo = new int[n + 1]; // memo[t] = c, 需要 cost 來得到
        Array.Fill(memo, (int)1e9);
        memo[0] = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = n; j > 0; j--)
            {
                int not_take = memo[j];
                int take = memo[Math.Max(j - time[i] - 1, 0)] + cost[i];
                memo[j] = Math.Min(not_take, take);
            }
        }
        return memo[n];
    }
}
