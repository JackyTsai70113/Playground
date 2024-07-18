namespace playground;

public class Solution0519
{
    Dictionary<int, int> d;
    Random random;
    int r, c, total;
    public Solution0519(int m, int n)
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