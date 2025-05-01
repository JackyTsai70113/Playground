namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/my-calendar-i
/// </summary>
public class _0729_MyCalendar
{
    readonly List<(int start, int end)> list = new();

    public bool Book(int start, int end)
    {
        int l = 0, r = list.Count - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (end <= list[m].start)
            {
                r = m - 1;
            }
            else if (list[m].end <= start)
            {
                l = m + 1;
            }
            else
            {
                break;
            }
        }
        if (l == list.Count || end <= list[l].start)
        {
            if (l < list.Count && end == list[l].start)
                list[l] = (start, list[l].end);
            else
                list.Insert(l, (start, end));
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class _0729_MyCalendar2
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

public class _0729_MyCalendar3
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
        if (l == list.Count - 1 && list[l].end < start) l++;
        if (l == list.Count || Math.Max(start, list[l].start) >= Math.Min(end, list[l].end))
        {
            if (l < list.Count && start == list[l].end)
                list[l] = (list[l].start, end);
            else if (l < list.Count && end == list[l].start)
                list[l] = (start, list[l].end);
            else
                list.Insert(l, (start, end));
            return true;
        }
        else
        {
            return false;
        }
    }
}