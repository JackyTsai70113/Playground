namespace playground;

public class Stacking_c471
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=c471
    /// </summary>
    public static long Stacking(int n, int[] weights, int[] times)
    {
        var objs = Enumerable
            .Range(0, n)
            .Select(i => (weight: weights[i], time: times[i]))
            .ToArray();
        Array.Sort(objs, (x, y) => x.weight * y.time - x.time * y.weight);
        int res = 0;
        for (int i = 0, sum = 0; i < n; i++)
        {
            res += sum * objs[i].time;
            sum += objs[i].weight;
        }
        return res;
    }
}
