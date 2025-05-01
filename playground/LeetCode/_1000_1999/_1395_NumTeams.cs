namespace playground;

public class _1395_NumTeams
{
    public static int NumTeams(int[] A)
    {
        int res = 0;
        int greaterBefore, lessBefore, greaterAfter, lessAfter;
        for (int i = 1; i < A.Length; i++)
        {
            greaterBefore = 0; lessBefore = 0; greaterAfter = 0; lessAfter = 0;
            for (int j = 0; j < i; j++)
            {
                if (A[j] < A[i])
                    lessBefore++;
                else
                    greaterBefore++;
            }
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[i] < A[j])
                    greaterAfter++;
                else
                    lessAfter++;
            }
            res += greaterBefore * lessAfter + lessBefore * greaterAfter;
        }
        return res;
    }
}
