namespace playground;

public class SetStations_c575
{
    /// <summary>
    /// https://zerojudge.tw/ShowProblem?problemid=c575
    /// </summary>
    public static int SetStations(int k, int[] positions)
    {
        Array.Sort(positions);
        int l = 1, r = positions[^1] - positions[0];
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (AtLeast(positions, m) <= k)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    public static int AtLeast(int[] positions, int diameter)
    {
        int cover = positions[0] + diameter;
        int res = 1;
        for (int i = 1; i < positions.Length; i++)
        {
            if (cover < positions[i])
            {
                res++;
                cover = positions[i] + diameter;
            }
        }
        return res;
    }
}
