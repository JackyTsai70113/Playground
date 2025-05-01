namespace playground.LeetCode._0000_0999;

public class _0373_KSmallestPairs
{
    /// <summary>
    /// https://leetcode.com/problems/find-k-pairs-with-smallest-sums
    /// </summary>
    public static IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var res = new List<IList<int>>();
        var pq = new PriorityQueue<(int, int), int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            pq.Enqueue((i, 0), nums1[i] + nums2[0]);
        }
        while (pq.Count > 0 && k-- > 0)
        {
            var (i, j) = pq.Dequeue();
            res.Add(new List<int> { nums1[i], nums2[j]
});
            if (j < nums2.Length - 1)
                pq.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
        }
        return res;
    }
}
