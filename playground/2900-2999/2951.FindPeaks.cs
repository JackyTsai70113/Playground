namespace playground;

public class FindPeaks_2951
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-peaks
    /// </summary>
    public static IList<int> FindPeaks(int[] A)
    {
        var res = new List<int>();
        for (int i = 1; i < A.Length - 1; ++i)
        {
            if (A[i - 1] < A[i] && A[i] > A[i + 1])
                res.Add(i);
        }
        return res;
    }
}
