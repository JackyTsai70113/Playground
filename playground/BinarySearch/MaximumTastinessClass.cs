namespace playground.BinarySearch;

public class MaximumTastinessClass
{
    /// <remarks>https://leetcode.com/problems/maximum-tastiness-of-candy-basket</remarks>
    public static int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        int n = price.Length, l = 0, r = price[n - 1] - price[0];
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            int pre = price[0], count = 1;
            for (int i = 1; i < n; ++i)
            {
                if (price[i] - pre >= m)
                {
                    count++;
                    pre = price[i];
                }
            }
            if (count >= k) l = m + 1;
            else r = m - 1;
        }
        return l - 1;
    }
}
