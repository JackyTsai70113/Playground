namespace playground.LeetCode._0000_0999;

public class _0519_Solution
{
    Dictionary<int, int> d;
    readonly Random random;
    private readonly int r;
    private readonly int c;
    private int total;

    public _0519_Solution(int m, int n)
    {
        d = new();
        random = new();
        r = m;
        c = n;
        total = m * n;
    }

    public int[] Flip()
    {
        var num = random.Next(total--);
        int x = d.GetValueOrDefault(num, num);
        d[num] = d.GetValueOrDefault(total, total);
        return new int[] { x / c, x % c };
    }

    public void Reset()
    {
        d = new();
        total = r * c;
    }
}