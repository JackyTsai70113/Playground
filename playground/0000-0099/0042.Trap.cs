namespace playground;

public class Trap_0042
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
}
