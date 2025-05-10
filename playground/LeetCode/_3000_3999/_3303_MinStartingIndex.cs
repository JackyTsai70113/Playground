using playground.Algorithms;

namespace playground.LeetCode._3000_3999;

public class _3303_MinStartingIndex
{
    public static int MinStartingIndex(string s, string pattern)
    {
        int n = s.Length, m = pattern.Length;
        int[] z1 = ZAlgorithm.ZFunction(pattern + s);
        string reversed = new((s + pattern).Reverse().ToArray());
        var z2 = ZAlgorithm.ZFunction(reversed);
        for (int i = 0; i <= n - m; ++i)
        {
            int leftMatch = z1[m + i];       // s[i:] 與 pattern 的前綴長度
            int rightMatch = z2[n - i];      // s[..i+m] 與 pattern 後綴的反轉匹配

            if (leftMatch + rightMatch + 1 >= m)
                return i;
        }
        return -1;
    }
}
