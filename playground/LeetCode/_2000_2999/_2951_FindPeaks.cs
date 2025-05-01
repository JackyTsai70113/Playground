namespace playground.LeetCode._2000_2999;

public class _2951_FindPeaks
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
