namespace playground.APCS;

public class F607_CutWood
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=f607
    /// </summary>
    public static int CutWood(int length, int[][] cuts)
    {
        Array.Sort(cuts, (x, y) => x[1] - y[1]);
        SortedSet<int> ss = new() { 0, length };
        var res = 0;
        for (int i = 0; i < cuts.Length; i++)
        {
            var cut = cuts[i][0];
            int l = ss.GetViewBetween(0, cut).Last();
            int r = ss.GetViewBetween(cut, length).First();
            ss.Add(cut);
            res += r - l;
        }
        return res;
    }
}
