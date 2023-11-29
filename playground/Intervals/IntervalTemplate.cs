namespace playground.Intervals;

public static class IntervalTemplate
{
    public static int[][] SortInterval(this int[][] A)
    {
        Array.Sort(A, (x, y) => x[0] == y[0] ? x[1] - y[1] : x[0] - y[0]);
        return A;
    }
}
