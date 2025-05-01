namespace playground.LeetCode._0000_0999;

public class _0862_ShortestSubarray
{
    public static int ShortestSubarray(int[] nums, int k)
    {
        int n = nums.Length, res = int.MaxValue;
        var presum = new long[n + 1];
        for (int i = 1; i <= n; i++)
            presum[i] = presum[i - 1] + nums[i - 1];
        var ll = new LinkedList<int>();
        ll.AddFirst(0);
        for (int r = 1; r <= n; r++)
        {
            // update state by A[r]
            while (ll.Count > 0 && presum[ll.Last.Value] >= presum[r])
            {
                ll.RemoveLast();
            }
            ll.AddLast(r);
            while (presum[r] - presum[ll.First.Value] >= k)
            {
                res = Math.Min(res, r - ll.First.Value);
                // update state by A[l]
                ll.RemoveFirst();
            }
        }
        return res == int.MaxValue ? -1 : res;
    }
}
