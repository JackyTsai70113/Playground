namespace playground.LeetCode._0000_0999;

public class _0295_MedianFinder
{
    private readonly PriorityQueue<int, int> low = new();
    private readonly PriorityQueue<int, int> high = new();

    public _0295_MedianFinder() { }

    public void AddNum(int num)
    {
        var x = low.EnqueueDequeue(num, -num);
        high.Enqueue(x, x);
        if (high.Count > low.Count + 1)
        {
            x = high.Dequeue();
            low.Enqueue(x, -x);
        }
    }

    public double FindMedian() =>
        low.Count == high.Count ?
            0.5 * (low.Peek() + high.Peek()) :
            high.Peek();
}
