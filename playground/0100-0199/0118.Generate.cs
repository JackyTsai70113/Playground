namespace playground;

public class Generate0118
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle
    /// </summary>
    public static IList<IList<int>> Generate(int numRows)
    {
        var res = new List<IList<int>>();
        res.Add(new List<int> { 1 });
        for (int i = 1; i < numRows; i++)
        {
            var cur = new List<int> { 1 };
            for (int j = 1; j < res[i - 1].Count; j++)
            {
                cur.Add(res[i - 1][j - 1] + res[i - 1][j]);
            }
            cur.Add(1);
            res.Add(cur);
        }
        return res;
    }
}
