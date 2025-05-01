namespace playground.LeetCode._0000_0999;

public class _0167_TwoSum
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
    /// </summary>
    public static int[] TwoSum(int[] A, int target)
    {
        int l = 0, r = A.Length - 1;
        var res = new int[2];
        while (l < r)
        {
            if (A[l] + A[r] < target)
                l++;
            else if (A[l] + A[r] > target)
                r--;
            else
            {
                (res[0], res[1]) = (l + 1, r + 1);
                break;
            }
        }
        return res;
    }
}
