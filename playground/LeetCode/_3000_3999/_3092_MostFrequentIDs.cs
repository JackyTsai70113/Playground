namespace playground;

public class _3092_MostFrequentIDs
{
    /// <summary>
    /// https://leetcode.com/problems/most-frequent-ids
    /// </summary>
    public static long[] MostFrequentIDs(int[] nums, int[] freq)
    {
        var pq = new PriorityQueue<(long count, int val), long>(Comparer<long>.Create((x, y) => y.CompareTo(x)));
        var counter = new Dictionary<int, long>();
        var res = new List<long>();
        for (int i = 0; i < nums.Length; i++)
        {
            var (num, f) = (nums[i], freq[i]);
            counter[num] = f + (counter.ContainsKey(num) ? counter[num] : 0);
            pq.Enqueue((counter[num], num), counter[num]);
            while (counter[pq.Peek().val] != pq.Peek().count)
                pq.Dequeue();
            res.Add(pq.Peek().count);
        }
        return res.ToArray();
    }
}
