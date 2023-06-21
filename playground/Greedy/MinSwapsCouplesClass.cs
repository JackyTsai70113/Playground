namespace playground.Greedy;

public class MinSwapsCouplesClass
{
    /// <remarks>https://leetcode.com/problems/couples-holding-hands</remarks>
    public static int MinSwapsCouples(int[] row)
    {
        static bool isCouple((int x, int y) a)
        {
            return a.x / 2 == a.y / 2;
        }

        static bool isArranged((int x, int y)[] seats)
        {
            foreach (var s in seats)
                if (!isCouple(s)) return false;
            return true;
        }

        static string toKey((int x, int y)[] seats)
        {
            var res = new string[seats.Length];
            for (int i = 0; i < seats.Length; ++i)
            {
                res[i] = seats[i].x + "_" + seats[i].y;
            }
            return string.Join(',', res);
        }

        int n = row.Length, res = 0;
        var seats = new (int x, int y)[n / 2];
        for (int i = 0; i < n; i += 2) seats[i / 2] = (row[i], row[i + 1]);

        var q = new Queue<((int x, int y)[], int d)>();
        q.Enqueue((seats, 0));
        var set = new HashSet<string> { toKey(seats) };
        while (q.Count > 0)
        {
            var (s, d) = q.Dequeue();
            if (isArranged(s))
            {
                res = d;
                break;
            }
            int i = 0;
            while (isCouple(s[i])) i++;
            for (int j = i + 1; j < n / 2; ++j)
            {
                if (isCouple(s[j])) continue;
                if (isCouple((s[i].x, s[j].x)))
                {
                    (s[i].y, s[j].x) = (s[j].x, s[i].y);
                }
                else if (isCouple((s[i].x, s[j].y)))
                {
                    (s[i].y, s[j].y) = (s[j].y, s[i].y);
                }
                if (set.Add(toKey(s))) q.Enqueue((s, d + 1));
            }
        }
        return res;
    }
}
