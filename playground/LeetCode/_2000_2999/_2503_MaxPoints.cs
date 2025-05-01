namespace playground.LeetCode._2000_2999;

public class _2503_MaxPoints
{
    public static int[] MaxPoints(int[][] A, int[] qs)
    {
        var arr = qs.Select((x, i) => (x, i)).OrderBy(y => y.x).ToArray();
        int m = A.Length, n = A[0].Length;
        var q = new PriorityQueue<(int r, int c), int>();
        q.Enqueue((0, 0), A[0][0]);
        var seen = new bool[m, n];
        seen[0, 0] = true;
        var res = new int[arr.Length];
        var dirs = new int[] { -1, 0, 1, 0, -1 };
        int point = 0;
        foreach (var (val, idx) in arr)
        {
            while (q.Count > 0)
            {
                var (r, c) = q.Peek();
                if (A[r][c] >= val)
                    break;
                q.Dequeue();
                point++;
                for (int i = 0; i < 4; i++)
                {
                    int rr = r + dirs[i];
                    int cc = c + dirs[i + 1];
                    if (rr < 0 || cc < 0 || rr == m || cc == n || seen[rr, cc])
                        continue;
                    seen[rr, cc] = true;
                    q.Enqueue((rr, cc), A[rr][cc]);
                }
            }
            res[idx] = point;
        }

        return res;
    }
}
