namespace playground.LeetCode._2000_2999;

/// <summary>
/// https://leetcode.com/problems/range-frequency-queries
/// </summary>
/// <remarks>
/// #segmentTree
/// </remarks>
public class _2080_RangeFreqQuery
{
    readonly Dictionary<int, int>[] segment;
    readonly int n;

    /// <summary>
    /// Constructs an instance of the class with the given 0-indexed integer array `arr`.
    /// </summary>
    public _2080_RangeFreqQuery(int[] arr)
    {
        n = arr.Length;
        segment = new Dictionary<int, int>[n * 4];
        for (int i = 0; i < n * 4; i++) segment[i] = new();
        Build(0, 0, n - 1, arr);
    }

    /// <summary>
    /// Returns the frequency of value in the subarray `arr[left...right]`.
    /// </summary>
    public int Query(int left, int right, int value)
    {
        return QueryRange(0, 0, n - 1, left, right, value);
    }

    /// <summary>
    /// Build the segment tree from an initial array
    /// </summary>
    public void Build(int i, int start, int end, int[] arr)
    {
        if (start == end)
        {
            segment[i][arr[start]] = 1;
            return;
        }
        int mid = start + (end - start) / 2;
        Build(i * 2 + 1, start, mid, arr);
        Build(i * 2 + 2, mid + 1, end, arr);

        foreach (var kvp in segment[i * 2 + 1])
            segment[i][kvp.Key] = kvp.Value;
        foreach (var kvp in segment[i * 2 + 2])
            segment[i][kvp.Key] = segment[i].ContainsKey(kvp.Key) ? segment[i][kvp.Key] + kvp.Value : kvp.Value;
    }

    public int QueryRange(int i, int start, int end, int l, int r, int value)
    {
        if (r < start || end < l)
        {
            return 0;
        }

        if (l <= start && end <= r)
        {
            return segment[i].ContainsKey(value) ? segment[i][value] : 0;
        }
        int mid = start + (end - start) / 2;
        var left = QueryRange(i * 2 + 1, start, mid, l, r, value);
        var right = QueryRange(i * 2 + 2, mid + 1, end, l, r, value);
        return left + right;
    }
}

public class _2080_RangeFreqQuery2
{
    readonly Dictionary<int, List<int>> count = new();

    /// <summary>
    /// Constructs an instance of the class with the given 0-indexed integer array `arr`.
    /// </summary>
    public _2080_RangeFreqQuery2(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (!count.ContainsKey(arr[i]))
                count[arr[i]] = new();
            count[arr[i]].Add(i);
        }
    }

    public int Query(int left, int right, int value)
    {
        if (!count.ContainsKey(value)) return 0;
        int i, j;
        int l = 0, r = count[value].Count;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (count[value][m] >= left)
                r = m;
            else
                l = m + 1;
        }
        i = l;
        l = 0; r = count[value].Count;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (count[value][m] >= right + 1)
                r = m;
            else
                l = m + 1;
        }
        j = l;
        return j - i;
    }
}
