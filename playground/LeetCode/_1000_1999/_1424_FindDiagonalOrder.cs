namespace playground;

public class _1424_FindDiagonalOrder
{
    /// <summary>
    /// https://leetcode.com/problems/diagonal-traverse-ii
    /// </summary>
    public static int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        var ll = new List<List<int>>();
        for (int i = 0; i < nums.Count; ++i)
        {
            for (int j = 0; j < nums[i].Count; ++j)
            {
                if (i + j >= ll.Count)
                    ll.Add(new List<int>());
                ll[i + j].Add(nums[i][j]);
            }
        }
        return ll.Select(x => { x.Reverse(); return x; }).SelectMany(x => x).ToArray();
    }
}
