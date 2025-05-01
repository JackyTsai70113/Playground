namespace playground._3300_3399;

public class _3394_CheckValidCuts
{
    public static bool CheckValidCuts(int n, int[][] A)
    {
        Array.Sort(A, (x, y) => x[0] != y[0] ? x[0] - y[0] : x[2] - y[2]);
        int section = 0;
        for (int i = 0; i < A.Length; i++)
        {
            int last = A[i][2];
            while (i + 1 < A.Length && A[i + 1][0] < last)
            {
                last = Math.Max(last, A[i + 1][2]);
                i++;
            }
            section++;
            if (section == 3)
            {
                return true;
            }
        }

        Array.Sort(A, (x, y) => x[1] != y[1] ? x[1] - y[1] : x[3] - y[3]);
        section = 0;
        for (int i = 0; i < A.Length; i++)
        {
            int last = A[i][3];
            while (i + 1 < A.Length && A[i + 1][1] < last)
            {
                last = Math.Max(last, A[i + 1][3]);
                i++;
            }
            section++;
            if (section == 3)
            {
                return true;
            }
        }
        return false;
    }
}
