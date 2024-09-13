namespace playground;

public class MinAvailableDuration1229
{
    public static IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
    {
        Array.Sort(slots1, (x, y) => x[0] - y[0]);
        Array.Sort(slots2, (x, y) => x[0] - y[0]);
        var res = new List<int>();
        int i = 0, j = 0;
        while (i < slots1.Length && j < slots2.Length)
        {
            int start = Math.Max(slots1[i][0], slots2[j][0]);
            int end = Math.Min(slots1[i][1], slots2[j][1]);

            if (end - start >= duration) return new List<int>() { start, start + duration };

            if (slots1[i][1] < slots2[j][1])
                i++;
            else
                j++;
        }
        return new List<int>();
    }
}
