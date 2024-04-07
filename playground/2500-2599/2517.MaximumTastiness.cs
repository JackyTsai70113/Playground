namespace playground;

public class MaximumTastiness2517
{
    public static int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        int l = 0, r = price[^1] - price[0], res = r;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            int count = 1, last = price[0];
            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] - last >= m)
                {
                    count++;
                    last = price[i];
                }
            }
            if (count >= k)
            {
                res = m;
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }
        return res;
    }
}
