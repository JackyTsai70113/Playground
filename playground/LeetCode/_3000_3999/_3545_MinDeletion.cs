namespace playground.LeetCode._3000_3999;

public class _3545_MinDeletion
{
    public static int MinDeletion(string s, int k)
    {
        var counts = new int[26];
        foreach (var c in s)
        {
            counts[c - 'a']++;
        }
        counts = counts
            .Where(x => x > 0)
            .OrderBy(x => x)
            .ToArray();
        if (counts.Length <= k)
            return 0;
        return counts.Take(counts.Length - k).Sum();
    }
}
