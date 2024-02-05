namespace playground;

public class FindKthLargest0215
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-an-array
    /// </summary>
    public static int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>();
        foreach (var num in nums)
        {
            pq.Enqueue(num, num);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        return pq.Peek();
    }
}
