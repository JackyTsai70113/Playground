namespace playground;

public class CountDays3169
{
    /// <summary>
    /// https://leetcode.com/problems/count-days-without-meetings
    /// </summary>
    /// <param name="days"></param>
    /// <param name="A"></param>
    /// <returns></returns>
    public static int CountDays(int days, int[][] A)
    {
        Array.Sort(A, (x, y) =>
        {
            if (x[0] == y[0])
                return x[1] - y[1];
            return x[0] - y[0];
        });
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i - 1][1] >= A[i][0])
            {
                A[i][0] = A[i - 1][0];
                A[i][1] = Math.Max(A[i][1], A[i - 1][1]);
            }
            else
            {
                days -= A[i - 1][1] - A[i - 1][0] + 1;
            }
        }
        days -= A[^1][1] - A[^1][0] + 1;
        return days;
    }
}
