namespace playground.Greedy;

public class MaxScoreClass
{

    public static long MaxScore(int[] nums1, int[] nums2, int k)
    {
        Array.Sort(nums2, nums1);
        long sum = 0;
        var pq = new PriorityQueue<int, int>();
        for (int i = 1; i <= k; ++i)
        {
            pq.Enqueue(nums1[^i], nums1[^i]);
            sum += nums1[^i];
        }
        long res = sum * nums2[^k];
        for (int i = k + 1; i <= nums1.Length; ++i)
        {
            sum += nums1[^i] - pq.EnqueueDequeue(nums1[^i], nums1[^i]);
            res = Math.Max(res, sum * nums2[^i]);
        }
        return res;
    }
}
