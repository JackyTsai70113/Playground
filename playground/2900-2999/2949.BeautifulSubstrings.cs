namespace playground;

public class BeautifulSubstrings_2949
{
    /// <summary>
    /// https://leetcode.com/problems/count-beautiful-substrings-ii
    /// </summary>
    public static long BeautifulSubstrings(string s, int k)
    {
        int n = s.Length;
        var vs = new char[] { 'a', 'e', 'i', 'o', 'u' }.ToHashSet();
        long res = 0;
        var d = new Dictionary<int, List<int>>();
        for (int i = 0, curCount = 0; i < n; ++i)
        {
            if (vs.Contains(s[i]))
                curCount++;
            if (i + 1 == curCount * 2 && curCount * curCount % k == 0)
                res++;
            var val = curCount * 2 - i; // 2(Count_j - Count_i) = j - i
            if (!d.ContainsKey(val))
                d[val] = new();
            foreach (var prevCount in d[val])
            {
                int subCount = curCount - prevCount;
                if (subCount * subCount % k == 0)
                    res++;
            }
            d[val].Add(curCount);
        }
        return res;
    }
}
