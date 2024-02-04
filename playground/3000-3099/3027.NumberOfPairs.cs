namespace playground;

public class NumberOfPairs3027
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-number-of-ways-to-place-people-ii
    /// </summary>
    public static int NumberOfPairs(int[][] A)
    {
        A = A.OrderBy(a => a[0]).ThenBy(a => -a[1]).ToArray();
        int n = A.Length, res = 0, max;
        for (int i = 0; i < n; i++)
        {
            max = int.MinValue;
            for (int j = i + 1; j < n; j++)
            {
                if (A[i][1] >= A[j][1] && A[j][1] > max)
                {
                    res++;
                    max = A[j][1];
                }
            }
        }
        return res;
    }
}
