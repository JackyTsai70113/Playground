namespace playground.BinarySearch;
public class MaximumBeautyClass
{
    /// <summary>
    /// https://leetcode.com/problems/most-beautiful-item-for-each-query/
    /// </summary>
    public static int[] MaximumBeauty(int[][] items, int[] queries)
    {
        items = items
            .OrderBy(x => x[0])
            .ThenBy(x => x[1])
            .ToArray();
        var qs = queries.Select((x, i) => new int[] { x, i }).OrderBy(x => x[0]).ToArray();
        for (int i = 1; i < items.Length; ++i)
        {
            items[i][1] = Math.Max(items[i][1], items[i - 1][1]);
        }
        int n = qs.Length;
        int[] res = new int[n];
        for (int i = 0, l = 0; i < n; ++i)
        {
            int ll = l, rr = items.Length, m;
            while (ll < rr)
            {
                m = ll + ((rr - ll) / 2);
                if (items[m][0] <= qs[i][0])
                {
                    ll = m + 1;
                }
                else
                {
                    rr = m;
                }
            }
            if (ll > 0)
            {
                res[qs[i][1]] = items[ll - 1][1];
            }

            l = ll;
        }
        return res;
    }
}