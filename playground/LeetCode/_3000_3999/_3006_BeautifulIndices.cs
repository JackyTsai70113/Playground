namespace playground;

public class _3006_BeautifulIndices
{
    /// <summary>
    /// https://leetcode.com/problems/find-beautiful-indices-in-the-given-array-i
    /// </summary>
    public static IList<int> BeautifulIndices(string s, string a, string b, int k)
    {
        int n = s.Length, n1 = a.Length, n2 = b.Length;
        var l1 = s.Select((x, i) => i)
            .Where((x, i) => i <= n - n1 && s.Substring(i, a.Length) == a)
            .ToList();
        var l2 = s.Select((x, i) => i)
            .Where((x, i) => i <= n - n2 && s.Substring(i, b.Length) == b)
            .ToList();
        var res = new List<int>();
        foreach (var i in l1)
        {
            int l = 0, r = l2.Count - 1;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (l2[m] >= i - k)
                {
                    r = m;
                }
                else
                    l = m + 1;
            }
            if (l != l2.Count && l2[l] >= i - k && l2[l] <= i + k)
                res.Add(i);
        }
        return res;
    }
}
