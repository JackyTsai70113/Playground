namespace playground;

public class LuckyNumbers1380
{
    public static IList<int> LuckyNumbers(int[][] A)
    {
        var minSet = new HashSet<int>();
        var colMax = new int[A[0].Length];
        for (int i = 0; i < A.Length; i++)
        {
            var min = int.MaxValue;
            for (int j = 0; j < A[0].Length; j++)
            {
                min = Math.Min(min, A[i][j]);
                colMax[j] = Math.Max(colMax[j], A[i][j]);
            }
            minSet.Add(min);
        }
        var res = new List<int>();
        foreach (var max in colMax)
        {
            if (minSet.Contains(max))
                res.Add(max);
        }
        return res;
    }
}
