namespace playground.LeetCode._0000_0999;

public class _0447_NumberOfBoomerangs
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-boomerangs
    /// </summary>
    public static int NumberOfBoomerangs(int[][] A)
    {
        int n = A.Length, res = 0;
        var d = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;
                var distance = (A[j][0] - A[i][0]) * (A[j][0] - A[i][0]);
                distance += (A[j][1] - A[i][1]) * (A[j][1] - A[i][1]);
                d[distance] = d.ContainsKey(distance) ? d[distance] + 1 : 1;
            }
            foreach (var val in d.Values)
            {
                res += val * (val - 1);
            }
            d.Clear();
        }
        return res;
    }
}
