namespace playground;

public class UniqueOccurrences1207
{
    /// <summary>
    /// https://leetcode.com/problems/unique-number-of-occurrences
    /// </summary>
    public static bool UniqueOccurrences(int[] arr) {
        var d = new Dictionary<int, int>();
        foreach(var num in arr)
            d[num] = d.ContainsKey(num) ? d[num] + 1 : 1;
        return d.Values.Count() == d.Values.Distinct().Count();
    }
}
