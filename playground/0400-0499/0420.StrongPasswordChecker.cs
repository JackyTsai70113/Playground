namespace playground;

public class StrongPasswordChecker0420
{
    /// <summary>
    /// https://leetcode.com/problems/strong-password-checker
    /// </summary>
    public static int StrongPasswordChecker(string A)
    {
        int missing = 3, same = 0, replace = 0, one = 0, two = 0;
        if (A.Any(c => 'a' <= c && c <= 'z')) missing--;
        if (A.Any(c => 'A' <= c && c <= 'Z')) missing--;
        if (A.Any(c => char.IsDigit(c))) missing--;
        if (A.Length < 6)
            return Math.Max(missing, 6 - A.Length);
        for (int i = 0; i <= A.Length; i++)
        {
            if (i < A.Length && (i == 0 || A[i - 1] == A[i]))
            {
                same++;
            }
            else
            {
                if (same >= 3)
                {
                    replace += same / 3;
                    if (same % 3 == 0) one++;
                    else if (same % 3 == 1) two++;
                }
                same = 1;
            }
        }
        if (A.Length < 20)
            return Math.Max(missing, replace);
        int delete = A.Length - 20;
        replace -= Math.Min(delete, one);
        replace -= Math.Min(Math.Max(delete - one, 0), two * 2) / 2;
        replace -= Math.Max(delete - one - two * 2, 0) / 3;
        return delete + Math.Max(missing, replace);
    }
}
