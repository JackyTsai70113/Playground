namespace playground.LeetCode._0000_0999;

public class _0028_StrStr
{
    public static int StrStr(string A, string B)
    {
        if (B.Length > A.Length)
            return -1;
        for (int i = 0; i <= A.Length - B.Length; ++i)
        {
            int j = 0;
            while (A[i + j] == B[j])
            {
                j++;
                if (j == B.Length)
                    return i;
            }
        }
        return -1;
    }
}
