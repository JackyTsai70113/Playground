namespace playground;

public class _3159_OccurrencesOfElement
{
    /// <summary>
    /// https://leetcode.com/problems/find-occurrences-of-an-element-in-an-array
    /// </summary>
    public static int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        var l = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == x)
                l.Add(i);
        }
        var res = new List<int>();
        foreach (var q in queries)
        {
            if (q - 1 < l.Count)
                res.Add(l[q - 1]);
            else
                res.Add(-1);
        }
        return res.ToArray();
    }
}
