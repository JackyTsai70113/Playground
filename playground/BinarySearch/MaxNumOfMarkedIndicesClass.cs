namespace playground.BinarySearch;

public class MaxNumOfMarkedIndicesClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-number-of-marked-indices
    /// </summary>
    public static int MaxNumOfMarkedIndices(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length, l = n / 2, r = n, m, res = 0;
        for (int i = 0; i < n / 2 && l < n; ++i)
        {
            int ll = l, rr = r;
            while (ll < rr)
            {
                m = ll + (rr - ll) / 2;
                if (nums[m] >= nums[i] * 2)
                {
                    rr = m;
                }
                else
                {
                    ll = m + 1;
                }
            }
            if (ll < n)
            {
                res += 2;
            }
            l = ll + 1;
        }
        return res;
    }
}
