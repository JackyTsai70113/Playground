namespace playground.LeetCode._3000_3999;

public class _3531_CountCoveredBuildings
{
    public static int CountCoveredBuildings(int n, int[][] B)
    {
        var d = new Dictionary<(int, int), int>();
        for (int i = 0; i < B.Length; i++)
        {
            d[(B[i][0], B[i][1])] = 1;
        }
        Array.Sort(B, (a, b) => a[0] == b[0] ? a[1] - b[1] : a[0] - b[0]);
        for (int i = 1; i < B.Length; i++)
        {
            if (B[i - 1][0] == B[i][0])
                d[(B[i][0], B[i][1])]++;
        }

        Array.Sort(B, (a, b) => a[0] == b[0] ? b[1] - a[1] : a[0] - b[0]);
        for (int i = 1; i < B.Length; i++)
        {
            if (B[i - 1][0] == B[i][0])
                d[(B[i][0], B[i][1])]++;
        }

        Array.Sort(B, (a, b) => a[1] == b[1] ? a[0] - b[0] : a[1] - b[1]);
        for (int i = 1; i < B.Length; i++)
        {
            if (B[i - 1][1] == B[i][1])
                d[(B[i][0], B[i][1])]++;
        }

        Array.Sort(B, (a, b) => a[1] == b[1] ? b[0] - a[0] : a[1] - b[1]);
        for (int i = 1; i < B.Length; i++)
        {
            if (B[i - 1][1] == B[i][1])
                d[(B[i][0], B[i][1])]++;
        }
        int count = 0;
        foreach (var kvp in d)
        {
            if (kvp.Value == 5)
                count++;
        }
        return count;
    }
}
