namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/insert-delete-getrandom-o1
/// </summary>
public class _0380_RandomizedSet
{
    readonly Random random = new();
    readonly IDictionary<int, int> valToPosition;
    readonly IList<int> l;
    public _0380_RandomizedSet()
    {
        valToPosition = new Dictionary<int, int>();
        l = new List<int>();
    }

    public bool Insert(int val)
    {
        if (valToPosition.ContainsKey(val)) return false;
        valToPosition.Add(val, l.Count);
        l.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!valToPosition.ContainsKey(val)) return false;
        if (valToPosition[val] != l.Count - 1)
        {
            l[valToPosition[val]] = l[^1];
            valToPosition[l[^1]] = valToPosition[val];
        }
        l.RemoveAt(l.Count - 1);
        valToPosition.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        int index = random.Next(l.Count);
        return l[index];
    }
}
