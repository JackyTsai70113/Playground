namespace playground;

public class _1207_UniqueOccurrences
{
    /// <summary>
    /// https://leetcode.com/problems/unique-number-of-occurrences
    /// </summary>
    public static bool UniqueOccurrences(int[] arr)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in arr)
            d[num] = d.ContainsKey(num) ? d[num] + 1 : 1;
        return d.Values.Count == d.Values.Distinct().Count();
    }
}
