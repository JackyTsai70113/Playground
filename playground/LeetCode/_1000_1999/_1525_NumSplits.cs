namespace playground.LeetCode._1000_1999;

public class _1525_NumSplits
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-good-ways-to-split-a-string
    /// </summary>
    public static int NumSplits(string s)
    {
        int[] chs1 = new int[26], chs2 = new int[26];
        int distinct1 = 0, distinct2 = 0;
        foreach (var c in s)
        {
            if (++chs2[c - 'a'] == 1)
                distinct2++;
        }
        int res = 0;
        foreach (var c in s)
        {
            if (++chs1[c - 'a'] == 1)
            {
                distinct1++;
            }
            if (--chs2[c - 'a'] == 0)
            {
                distinct2--;
            }
            if (distinct1 == distinct2)
                res++;
        }
        return res;
    }
}
