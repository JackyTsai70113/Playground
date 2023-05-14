namespace playground.UnionFinds;

public class FindCircleNumClass
{
    public static int FindCircleNum(int[][] A)
    {
        var uf = new UnionFind(A.Length);
        for (int i = 0; i < A.Length; ++i)
        {
            for (int j = i + 1; j < A.Length; ++j)
            {
                if (A[i][j] == 1)
                {
                    if (!uf.AreConnected(i, j))
                    {
                        uf.Join(i, j);
                    }
                }
            }
        }
        return uf.GroupCount();
    }
}
