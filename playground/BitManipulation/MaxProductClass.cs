namespace playground.BitManipulation;

public class MaxProductClass
{
    /// <remarks>https://leetcode.com/problems/maximum-product-of-word-lengths</remarks>
    public static int MaxProduct(string[] ws)
    {
        int n = ws.Length, res = 0;
        var cnt = new int[n];
        for (int i = 0; i < n; ++i)
        {
            foreach (var c in ws[i])
            {
                cnt[i] |= 1 << (c - 'a');
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                if ((cnt[i] | cnt[j]) == cnt[i] + cnt[j])
                    res = Math.Max(res, ws[i].Length * ws[j].Length);
            }
        }
        return res;
    }
}
