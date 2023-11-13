namespace playground;

public class ChalkReplacer_1894
{
    public static int ChalkReplacer(int[] A, int k)
    {
        long sum = 0;
        foreach (var a in A) sum += a;
        k = (int)((long)k % sum);
        int res = 0;
        for (int i = 0; i < A.Length; ++i)
        {
            if (k < A[i])
            {
                res = i;
                break;
            }
            k -= A[i];
        }
        return res;
    }
}
