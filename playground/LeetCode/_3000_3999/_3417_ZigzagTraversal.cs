namespace playground._3400_3499;

public class _3417_ZigzagTraversal
{
    public static IList<int> ZigzagTraversal(int[][] A)
    {
        var res = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < A[0].Length; j += 2)
                {
                    res.Add(A[i][j]);
                }
            }
            else
            {
                for (int j = (A[0].Length % 2 == 0 ? A[0].Length - 1 : A[0].Length - 2); j >= 0; j -= 2)
                {
                    res.Add(A[i][j]);
                }
            }
        }
        return res;
    }
}
