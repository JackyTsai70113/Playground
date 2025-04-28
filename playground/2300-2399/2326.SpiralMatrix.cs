using playground.Notes.DataStructure;

namespace playground;

public class SpiralMatrix2326
{
    public static int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        var res = new int[m][];
        for (int i = 0; i < m; ++i) res[i] = Enumerable.Repeat(-1, n).ToArray();
        int[] dirs = new int[] { 0, 1, 0, -1, 0 };
        int j = 0, r = 0, c = 0;
        var cur = head;
        while (cur != null)
        {
            res[r][c] = cur.val;
            int rr = r + dirs[j], cc = c + dirs[j + 1];
            if (rr < 0 || cc < 0 || rr == m || cc == n || res[rr][cc] != -1)
            {
                j = (j + 1) % 4;
                r += dirs[j];
                c += dirs[j + 1];
            }
            else
            {
                r = rr;
                c = cc;
            }
            cur = cur.next;
        }
        return res;
    }
}
