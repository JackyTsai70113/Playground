namespace playground.LeetCode._0000_0999;

public class _0909_SnakesAndLadders
{
    int n;
    public int SnakesAndLadders(int[][] A)
    {
        n = A.Length;

        var pos = new (int r, int c)[n * n + 1];
        int idx = 1;
        for (int r = n - 1, dir = 0; r >= 0; r--)
        {
            if (dir == 0)
            {
                for (int c = 0; c < n; c++) pos[idx++] = (r, c);
            }
            else
            {
                for (int c = n - 1; c >= 0; c--) pos[idx++] = (r, c);
            }
            dir ^= 1;
        }

        var seen = new bool[n * n + 1];
        var q = new Queue<int>();
        seen[1] = true;
        q.Enqueue(1);

        int step = 0;
        while (q.Count > 0)
        {
            for (int i = q.Count - 1; i >= 0; i--)
            {
                var curr = q.Dequeue();
                // Console.WriteLine(curr + " " + step);
                if (curr == n * n) return step;
                for (int next = curr + 1; next <= Math.Min(curr + 6, n * n); next++)
                {
                    var (r, c) = pos[next];
                    int dest = A[r][c] != -1 ? A[r][c] : next;
                    if (seen[dest]) continue;
                    seen[dest] = true;
                    q.Enqueue(dest);
                }
            }
            step++;
        }
        return -1;
    }
}
