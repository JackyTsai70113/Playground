namespace playground.LeetCode._2000_2999;

public class _2617_MinimumVisitedCells
{
    /// <summary>
    /// BFS 為了避免重複尋找，有幾種方式可以用：
    /// 1. seen[] 反向表列已經去過的，去過要註記不能再去
    /// 2. HashSet 正向表列還沒去過的，去完要刪掉
    /// 3. 若是使用 排序相關的訪問方式，可使用 sorted set
    public static int MinimumVisitedCells(int[][] A)
    {
        int m = A.Length, n = A[0].Length;

        var rowSet = new SortedSet<int>[n];
        for (int i = 0; i < n; i++)
            rowSet[i] = new SortedSet<int>(Enumerable.Range(0, m));
        var colSet = new SortedSet<int>[m];
        for (int i = 0; i < m; i++)
            colSet[i] = new SortedSet<int>(Enumerable.Range(0, n));

        var q = new Queue<(int r, int c)>();
        var seen = new bool[m, n];
        seen[0, 0] = true;
        q.Enqueue((0, 0));

        int step = 1;

        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; i--)
            {
                var (r, c) = q.Dequeue();
                if (r == m - 1 && c == n - 1) return step;

                // move down
                int maxR = Math.Min(m - 1, r + A[r][c]);
                if (r + 1 <= maxR)
                {
                    var availableR = rowSet[c].GetViewBetween(r + 1, maxR).ToList();
                    foreach (var nextR in availableR)
                    {
                        rowSet[c].Remove(nextR);
                        if (seen[nextR, c]) continue;
                        seen[nextR, c] = true;
                        q.Enqueue((nextR, c));
                    }
                }

                // move right
                int maxC = Math.Min(n - 1, c + A[r][c]);
                if (c + 1 <= maxC)
                {
                    var availableC = colSet[r].GetViewBetween(c + 1, maxC).ToList();
                    foreach (var nextC in availableC)
                    {
                        colSet[r].Remove(nextC);
                        if (seen[r, nextC]) continue;
                        seen[r, nextC] = true;
                        q.Enqueue((r, nextC));
                    }
                }
            }
            step++;
        }
        return -1;
    }

    /// <summary>
    /// 因誤使用 greedy 而產生無法走到的 bug 解法
    /// 
    /// 這題不能用 greedily 來找最遠已去過的因為中間可能會有沒去過的, 像是這樣
    /// [[2,1,1,1,0],
    ///  [0,0,0,2,1],
    ///  [3,0,0,0,0]]
    /// 其中的 (1,3) 因為 (2,0) 提前標記了 maxRow[3] = 2 而無法走到
    /// </summary>
    /// <param name="A"></param>
    /// <returns></returns>
    public static int MinimumVisitedCells_Greedy(int[][] A)
    {
        int m = A.Length, n = A[0].Length;

        int[] maxRows = new int[n], maxCols = new int[m];
        List<(int r, int c)> l1 = new() { (0, 0) };
        List<(int r, int c)> l2 = new();

        int step = 0;
        while (l1.Count > 0)
        {
            ++step;
            l2.Clear();
            foreach (var (r, c) in l1)
            {
                if (r == m - 1 && c == n - 1)
                    return step;
                for (int k = Math.Max(maxRows[c], r) + 1; k <= Math.Min(m - 1, A[r][c] + r); ++k)
                    l2.Add((k, c));
                for (int k = Math.Max(maxCols[r], c) + 1; k <= Math.Min(n - 1, A[r][c] + c); ++k)
                    l2.Add((r, k));
                maxRows[c] = Math.Max(maxRows[c], A[r][c] + r);
                maxCols[r] = Math.Max(maxCols[r], A[r][c] + c);
            }
            (l1, l2) = (l2, l1);
        }

        return -1;
    }
}
