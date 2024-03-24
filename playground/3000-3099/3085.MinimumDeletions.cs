namespace playground;

public class MinimumDeletions3085
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-deletions-to-make-string-k-special
    /// </summary>
    public static int MinimumDeletions(string word, int k)
    {
        var counts = new int[26];
        foreach (var c in word)
            counts[c - 'a']++;
        var res = int.MaxValue;
        foreach (var x in counts) // x: base
        {
            int cur = 0;
            foreach (var count in counts) // count: number need to be deleted
            {
                cur += (count < x ? count : Math.Max(0, count - (x + k)));
            }
            res = Math.Min(res, cur);
        }
        return res;
    }
}
