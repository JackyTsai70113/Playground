namespace playground._0500_0599;

public class _0556_NextGreaterElement
{
    public static int NextGreaterElement(int n)
    {
        var list = new List<int>();
        while (n > 0)
        {
            int cur = (int)(n % 10);
            n /= 10;
            int l = 0, r = list.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (list[m] > cur)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            if (l != list.Count)
            {
                long nn = n * 10 + list[l];
                list[l] = cur;
                for (int i = 0; i < list.Count; i++)
                {
                    nn = nn * 10 + list[i];
                }
                if (nn <= int.MaxValue)
                    return (int)nn;
            }
            list.Add(cur);
        }
        return -1;
    }
}
