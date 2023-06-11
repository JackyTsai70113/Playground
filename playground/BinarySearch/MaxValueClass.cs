namespace playground.BinarySearch;

public class MaxValueClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-value-at-a-given-index-in-a-bounded-array
    /// </summary>
    public static int MaxValue(int n, int index, int maxSum)
    {
        maxSum -= n;
        long GetSum(int val)
        {
            long sum = 0, leftVal = 1, rightVal = 1;
            if (index + 1 - val < 0)
            {
                leftVal = val - index;
            }
            sum += (leftVal + val) * (val - leftVal + 1) / 2;
            if (index + val > n)
            {
                rightVal = val - (n - index - 1);
            }
            sum += (val + rightVal) * (val - rightVal + 1) / 2;
            sum -= val;
            return sum;
        }

        int left = 0;
        int right = maxSum;
        while (left < right)
        {
            int mid = (left + right + 1) / 2;
            if (GetSum(mid) <= maxSum)
                left = mid;
            else
                right = mid - 1;
        }
        return left + 1;
    }
}
