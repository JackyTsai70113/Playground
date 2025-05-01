namespace playground.LeetCode._0000_0999;

public class _0427_Construct
{
    /// <summary>
    /// https://leetcode.com/problems/construct-quad-tree
    /// </summary>
    public static QuadTreeNode Construct(int[][] grid)
    {
        int n = grid.Length;
        return Dfs(grid, 0, n, 0, n);
    }

    static QuadTreeNode Dfs(int[][] A, int r0, int r1, int c0, int c1)
    {
        if (r0 + 1 == r1 && c0 + 1 == c1)
            return new QuadTreeNode(A[r0][c0] == 1, true, null, null, null, null);
        int rm = r0 + (r1 - r0) / 2;
        int cm = c0 + (c1 - c0) / 2;
        var tl = Dfs(A, r0, rm, c0, cm);
        var tr = Dfs(A, r0, rm, cm, c1);
        var bl = Dfs(A, rm, r1, c0, cm);
        var br = Dfs(A, rm, r1, cm, c1);
        if (tl.isLeaf && tr.isLeaf && bl.isLeaf && br.isLeaf &&
            tl.val == tr.val && tr.val == bl.val && bl.val == br.val)
        {
            return new QuadTreeNode(tl.val, true);
        }
        else
        {
            return new QuadTreeNode(true, false, tl, tr, bl, br);
        }
    }
}
