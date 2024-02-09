namespace playground;

/// <summary>
/// https://leetcode.com/problems/find-median-from-data-stream
/// </summary>
public class MedianFinder0295
{
    PriorityQueue<int, int> small = new(), big = new();
    public MedianFinder0295()
    {

    }

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
