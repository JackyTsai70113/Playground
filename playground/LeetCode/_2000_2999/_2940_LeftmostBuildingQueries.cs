namespace playground.LeetCode._2000_2999;

public class _2940_LeftmostBuildingQueries_cs
{
    public static int[] LeftmostBuildingQueries(int[] heights, int[][] queries)
    {
        int n = heights.Length, qz = queries.Length;
        var res = new int[qz];
        Array.Fill(res, -1);
        var idx = new List<(int h, int idx)>();
        for (int i = 0; i < qz; i++)
        {
            if (queries[i][0] > queries[i][1])
                (queries[i][0], queries[i][1]) = (queries[i][1], queries[i][0]);
            int x = queries[i][0], y = queries[i][1];
            if (x == y || heights[x] < heights[y])
                res[i] = y;
            else
                idx.Add((y, i));
        }
        idx.Sort((x, y) => x.h != y.h ? y.h - x.h : y.idx - x.idx);
        var linkedList = new LinkedList<(int h, int i)>();

        int j = n - 1;
        for (int ii = 0; ii < idx.Count; ii++)
        {
            int i = idx[ii].idx;
            int x = queries[i][0], y = queries[i][1];
            for (; j > y; j--)
            {
                while (linkedList.Count > 0 && heights[linkedList.Last.Value.i] < heights[j])
                    linkedList.RemoveLast();
                linkedList.AddLast((heights[j], j));
            }

            var sss = x + " " + y + " " + idx[ii].h + " " + i + " " + j + " " + linkedList.Count;
            int l = -1, r = linkedList.Count - 1;
            while (l < r)
            {
                int m = l + (r - l + 1) / 2;
                if (linkedList.ElementAt(m).h > heights[x])
                    l = m;
                else
                    r = m - 1;
            }
            res[i] = l == -1 ? -1 : linkedList.ElementAt(l).i;
            var aaa = i + " " + res[i];
        }
        return res;
    }
}
