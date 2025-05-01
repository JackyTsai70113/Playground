namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/find-median-from-data-stream
/// </summary>
public class _0295_MedianFinder
{
    private readonly PriorityQueue<int, int> small = new();
    private readonly PriorityQueue<int, int> big = new();

    public _0295_MedianFinder() { }

    public void AddNum(int num)
    {
        var x = small.EnqueueDequeue(num, -num);
        big.Enqueue(x, x);
        if (big.Count > small.Count + 1)
        {
            x = big.Dequeue();
            small.Enqueue(x, -x);
        }
    }

    public double FindMedian() =>
        small.Count == big.Count ?
            0.5 * (small.Peek() + big.Peek()) :
            big.Peek();
}
