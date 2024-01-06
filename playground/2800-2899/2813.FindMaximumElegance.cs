namespace playground;

public class FindMaximumElegance2813
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-elegance-of-a-k-length-subsequence
    /// </summary>
    /// <param name="items">[profit[i], category[i]]</param>
    /// <param name="k"></param>
    public static long FindMaximumElegance(int[][] items, int k)
    {
        long res = 0, totalProfit = 0;
        HashSet<int> categories = new();
        List<int> profitDups = new();
        Array.Sort(items, (x, y) => y[0] - x[0]);
        for (int i = 0; i < items.Length; i++)
        {
            int profit = items[i][0], category = items[i][1];
            if (i < k)
            {
                if (categories.Contains(category))
                {
                    profitDups.Add(profit);
                }
                totalProfit += profit;
            }
            else if (!categories.Contains(category))
            {
                if (!profitDups.Any())
                {
                    break;
                }
                totalProfit += profit - profitDups[^1];
                profitDups.RemoveAt(profitDups.Count - 1);
            }
            categories.Add(category);
            res = Math.Max(res, totalProfit + (long)categories.Count * categories.Count);
        }
        return res;
    }
}
