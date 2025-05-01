namespace playground;

public class _1802_MaxValue
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-value-at-a-given-index-in-a-bounded-array
    /// </summary>
    public static int MaxValue(int n, int index, int maxSum)
    {
        maxSum -= n;
        int l = 0, r = maxSum;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (Valid(n, index, maxSum, m))
                l = m;
            else
                r = m - 1;
        }
        return l + 1;
    }

    static bool Valid(int n, int index, int maxSum, int val)
    {
        long sum = -val;
        long leftVal = Math.Max(1, val - index);
        sum += (leftVal + val) * (val - leftVal + 1) / 2;
        long rightVal = Math.Max(1, val - (n - 1 - index));
        sum += (val + rightVal) * (val - rightVal + 1) / 2;
        return sum <= maxSum;
    }
}


/*
0 1 2 3 4
_ _ _ _ _
    *
0 1 2 1 0
*/
