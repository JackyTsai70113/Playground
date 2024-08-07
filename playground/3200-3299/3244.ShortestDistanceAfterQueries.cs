namespace playground;

public class ShortestDistanceAfterQueries3244
{
    public static int[] ShortestDistanceAfterQueries(int n, int[][] qs)
    {
        var next = new int[n];
        for (int i = 0; i < n; i++)
        {
            next[i] = i + 1;
        }
        var res = new int[qs.Length];
        for (int i = 0, step = n - 1; i < qs.Length; i++)
        {
            int start = qs[i][0], end = qs[i][1];
            if (next[start] > 0 && next[start] < end)
            {
                while (start != end)
                {
                    var temp = next[start];
                    next[start] = -1;
                    start = temp;
                    step--;
                }
                step++;
                next[qs[i][0]] = end;
            }
            res[i] = step;
        }
        return res;
    }
}
