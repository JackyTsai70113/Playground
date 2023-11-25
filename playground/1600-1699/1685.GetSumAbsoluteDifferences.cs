namespace playground;

public class GetSumAbsoluteDifferences_1685
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-absolute-differences-in-a-sorted-array
    /// </summary>
    public static int[] GetSumAbsoluteDifferences(int[] A)
    {
        int n = A.Length, leftSum = A.Sum();
        var res = new int[n];
        for (int i = n - 1, rightSum = 0; i >= 0; --i)
        {
            var left = (i + 1) * A[i] - leftSum;
            var right = rightSum - (n - 1 - i) * A[i];
            res[i] = left + right;
            leftSum -= A[i];
            rightSum += A[i];
        }
        return res;
    }
}
