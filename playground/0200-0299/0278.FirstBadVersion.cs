namespace playground;

public class FirstBadVersion0278
{
    private int _bad;

    /// <summary>
    /// https://leetcode.com/problems/first-bad-version
    /// </summary>
    public int FirstBadVersion(int n, int bad)
    {
        _bad = bad;
        int l = 1, r = n;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (IsBadVersion(m))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    private bool IsBadVersion(int k)
    {
        return k >= _bad;
    }
}
