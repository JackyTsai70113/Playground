namespace playground.Algorithms;

public class DynamicMedian
{
    /// <summary>
    /// 小於中位數的最大堆, (num, -num)
    /// </summary>
    private readonly PriorityQueue<double, double> maxHeap = new();

    // (num, num) 最小堆
    /// <summary>
    /// 大於中位數的最小堆, (num, num)
    /// </summary>
    private readonly PriorityQueue<double, double> minHeap = new();

    /// <summary>
    /// 延遲刪除表
    /// </summary>
    private readonly Dictionary<double, int> delayed = new();

    private int count = 0;

    /// <summary>
    /// 增加一個元素
    /// </summary>
    public void AddNum(int num)
    {
        if (maxHeap.Count == minHeap.Count)
        {
            var top = maxHeap.EnqueueDequeue(num, -num);
            minHeap.Enqueue(top, top);
        }
        else
        {
            var top = minHeap.EnqueueDequeue(num, num);
            maxHeap.Enqueue(top, -top);
        }

        count++;
    }

    /// <summary>
    /// 增加一個元素，刪除一個元素
    /// </summary>
    /// <remarks>目前僅支援增加後刪除，未支援純刪除</remarks>
    public void AddAndDelete(int numToAdd, int numToDelete)
    {
        var top = minHeap.EnqueueDequeue(numToAdd, numToAdd);
        maxHeap.Enqueue(top, -top);

        if (numToDelete > maxHeap.Peek())
        {
            var maxTop = maxHeap.Dequeue();
            minHeap.Enqueue(maxTop, maxTop);
        }
        delayed[numToDelete] = delayed.GetValueOrDefault(numToDelete) + 1;

        Prune(maxHeap);
        Prune(minHeap);
    }

    public double GetMedian()
    {
        if (count % 2 == 1)
            return minHeap.Peek(); // 總數是奇數，minHeap 多一個
        else
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }

    private void Prune(PriorityQueue<double, double> heap)
    {
        while (heap.Count > 0 && delayed.TryGetValue(heap.Peek(), out int freq))
        {
            var top = heap.Dequeue();
            delayed.Remove(top);
        }
    }
}