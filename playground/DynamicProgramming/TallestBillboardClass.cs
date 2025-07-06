namespace playground.DynamicProgramming;

public class TallestBillboardClass
{
    /// <summary>
    /// https://leetcode.com/problems/tallest-billboard
    /// </summary>
    public static int TallestBillboard(int[] rods)
    {
        Dictionary<int, int> memo = new()
        {
            [0] = 0
        }, cur;
        foreach (int x in rods)
        {
            cur = new(memo);
            foreach (int d in cur.Keys)
            {
                memo[d + x] = Math.Max(cur[d], memo.TryGetValue(x + d, out var v) ? v : 0);
                memo[Math.Abs(d - x)] = Math.Max(
                    memo.TryGetValue(Math.Abs(d - x), out v) ? v : 0,
                    cur[d] + Math.Min(d, x));
            }
        }
        return memo[0];
    }
}
