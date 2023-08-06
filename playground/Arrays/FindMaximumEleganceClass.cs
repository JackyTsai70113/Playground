namespace playground.Arrays;

public class FindMaximumEleganceClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-elegance-of-a-k-length-subsequence
    /// </summary>
    public static long FindMaximumElegance(int[][] items, int k)
    {
        long res = 0, totalProfit = 0;
        HashSet<int> seen = new();
        List<int> dups = new();
        Array.Sort(items, (x, y) => y[0] - x[0]);
        for (int i = 0; i < items.Length; ++i)
        {
            if (i < k)
            {
                if (seen.Contains(items[i][1]))
                {
                    dups.Add(items[i][0]);
                }
                totalProfit += items[i][0];
            }
            else if (!seen.Contains(items[i][1]))
            {
                if (dups.Count == 0)
                {
                    break;
                }
                totalProfit += items[i][0] - dups[^1];
                dups.RemoveAt(dups.Count - 1);
            }
            seen.Add(items[i][1]);
            res = Math.Max(res, totalProfit + (long)seen.Count * seen.Count);
        }
        return res;
    }
}
