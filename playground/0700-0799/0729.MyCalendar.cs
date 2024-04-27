namespace playground;

/// <summary>
/// https://leetcode.com/problems/my-calendar-i
/// </summary>
public class MyCalendar
{
    readonly List<(int start, int end)> list = new();

    public bool Book(int start, int end)
    {
        int l = 0, r = list.Count - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (start < list[m].end)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        if (l == list.Count || Math.Min(list[l].end, end) <= Math.Max(start, list[l].start))
        {
            if (l == list.Count || l == list.Count - 1 && list[l].end < start)
                list.Add((start, end));
            else if (Math.Min(list[l].end, end) < Math.Max(start, list[l].start))
                list.Insert(l, (start, end));
            else if (list[l].end <= start)
                list[l] = (list[l].start, end);
            else
                list[l] = (start, list[l].end);
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class MyCalendar2
{
    readonly SortedSet<(int start, int end)> ss =
        new(Comparer<(int start, int end)>.Create((x, y) =>
            {
                if (x.end <= y.start)
                    return -1;
                if (y.end <= x.start)
                    return 1;
                return 0;
            }));

    public bool Book(int start, int end)
    {
        return ss.Add((start, end));
    }
}