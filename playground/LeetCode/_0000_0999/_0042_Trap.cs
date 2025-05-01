namespace playground.LeetCode._0000_0999;

public class _0042_Trap
{
    /// <summary>
    /// https://leetcode.com/problems/trapping-rain-water
    /// </summary>
    public static int Trap(int[] A)
    {
        int l = 0, r = A.Length - 1, leftMax = 0, rightMax = 0, res = 0;
        while (l < r)
        {
            if (A[l] < A[r])
            {
                if (A[l] > leftMax) leftMax = A[l];
                else res += leftMax - A[l];
                l++;
            }
            else
            {
                if (A[r] > rightMax) rightMax = A[r];
                else res += rightMax - A[r];
                r--;
            }
        }
        return res;
    }

    public static int Trap2(int[] A)
    {
        int n = A.Length, maxi = -1;
        int[] backwardMax = new int[n];
        for (int i = 0; i < n; ++i)
        {
            if (maxi == -1 || A[i] >= A[maxi])
                maxi = i;
            backwardMax[i] = maxi;
        }

        maxi = n;
        int[] forwardMax = new int[n];
        for (int i = n - 1; i >= 0; --i)
        {
            if (maxi == n || A[i] >= A[maxi])
                maxi = i;
            forwardMax[i] = maxi;
        }

        var res = 0;
        for (int i = 0; i < n; i++)
        {
            res += Math.Min(A[backwardMax[i]], A[forwardMax[i]]) - A[i];
        }
        return res;
    }
}
