using System.Text;

namespace playground._3300_3399;

public class _3303_MinStartingIndex
{
    public static int MinStartingIndex(string s, string pattern)
    {
        int n = s.Length, m = pattern.Length;
        int[] z1 = ZFunction(pattern + s);
        int[] z2 = ZFunction(new string((s + pattern).ToCharArray().Reverse().ToArray()));
        for (int i = 0; i <= n - m; ++i)
            if (z1[m + i] + 1 + z2[n - i] >= m)
                return i;
        return -1;
    }

    private static int[] ZFunction(String s)
    {
        int n = s.Length, l = 0, r = 0;
        int[] z = new int[n];
        for (int i = 1; i < n; ++i)
        {
            if (i <= r)
            {
                z[i] = Math.Min(r - i + 1, z[i - l]);
            }
            while (i + z[i] < n && s[z[i]] == s[i + z[i]])
            {
                ++z[i];
            }
            if (i + z[i] - 1 > r)
            {
                l = i;
                r = i + z[i] - 1;
            }
        }
        return z;
    }
}
