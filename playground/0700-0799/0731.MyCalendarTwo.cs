namespace playground;

public class MyCalendarTwo0731
{
    readonly SortedSet<(int, int)> ss;
    readonly SortedSet<(int, int)> ss2;
    public MyCalendarTwo0731()
    {
        Comparer<(int, int)> comparer = Comparer<(int start, int end)>.Create((x, y) =>
            {
                if (x.end <= y.start)
                    return -1;
                if (y.end <= x.start)
                    return 1;
                return 0;
            });
        ss = new(comparer);
        ss2 = new(comparer);
    }
    public bool Book(int start, int end)
    {
        if (ss.Add((start, end))) return true;
        var overlaps = ss.GetViewBetween((start, int.MaxValue), (int.MinValue, end)).ToList();
        List<(int start, int end)> intersections = new(), unions = new();
        foreach (var overlap in overlaps)
        {
            ss.Remove(overlap);
            intersections.Add(GetIntersection(overlap, (start, end)));
            unions.Add(GetUnion(overlap, (start, end)));
        }
        foreach (var union in unions)
        {
            if (ss.TryGetValue(union, out (int start, int end) val))
            {
                ss.Remove(val);
                ss.Add((Math.Min(union.start, val.start), Math.Max(union.end, val.end)));
            }
            
            else
            {
                ss.Add(union);
            }
        }

        var res = true;
        var additions = new List<(int, int)>();
        foreach (var intersection in intersections)
        {
            if (!ss2.Add(intersection))
            {
                res = false;
                break;
            }
            additions.Add(intersection);
        }
        if (!res)
        {
            foreach (var union in unions)
                ss.Remove(union);
            foreach (var overlap in overlaps)
                ss.Add(overlap);
            foreach (var addition in additions)
                ss2.Remove(addition);
        }
        return res;
    }

    private static (int start, int end) GetIntersection((int start, int end) a, (int start, int end) b)
    {
        return (Math.Max(a.start, b.start), Math.Min(a.end, b.end));
    }

    private static (int start, int end) GetUnion((int start, int end) a, (int start, int end) b)
    {
        return (Math.Min(a.start, b.start), Math.Max(a.end, b.end));
    }
}
