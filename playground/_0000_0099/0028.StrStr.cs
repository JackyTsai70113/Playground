namespace playground;

public class StrStr_0028
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
