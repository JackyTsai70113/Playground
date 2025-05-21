namespace playground.LeetCode._1000_1999;

public class _1425_ConstrainedSubsetSum
{
    public static int ConstrainedSubsetSum(int[] nums, int k)
    {
        var res = nums[0];
        var ll = new LinkedList<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            nums[i] += ll.Count > 0 ? ll.First.Value : 0;
            res = Math.Max(res, nums[i]);
            while (ll.Count > 0 && ll.Last.Value < nums[i])
                ll.RemoveLast();
            if (nums[i] > 0)
                ll.AddLast(nums[i]);
            if (i >= k && ll.Count > 0 && ll.First.Value == nums[i - k])
                ll.RemoveFirst();
        }
        return res;
    }
}
