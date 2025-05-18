using playground.Algorithms;

namespace playground.LeetCode._0000_0999;

public class _0480_MedianSlidingWindow
{
    public static double[] MedianSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;
        var res = new double[n - k + 1];
        PriorityQueue<int, int> low = new(); // max heap [0:k/2]
        PriorityQueue<int, int> high = new(); // min heap [k/2: k]
        var removed = new Dictionary<int, int>();
        for (int i = 0; i < k; i++)
        {
            if (low.Count == high.Count)
            {
                var element = low.EnqueueDequeue(nums[i], -nums[i]);
                high.Enqueue(element, element);
            }
            else
            {
                var element = high.EnqueueDequeue(nums[i], nums[i]);
                low.Enqueue(element, -element);
            }
        }
        res[0] = (k & 1) == 0 ?
            (low.Peek() + high.Peek()) / 2.0 :
            high.Peek();
        for (int i = k; i < n; i++)
        {
            var highPeek = high.EnqueueDequeue(nums[i], nums[i]);
            low.Enqueue(highPeek, -highPeek);

            // remove element out of range
            int outNum = nums[i - k];
            if (outNum > low.Peek())
            {
                var lowPeek = low.Dequeue();
                high.Enqueue(lowPeek, lowPeek);
            }
            removed[outNum] = removed.GetValueOrDefault(outNum) + 1;
            while (low.Count > 0 && removed.GetValueOrDefault(low.Peek()) > 0)
            {
                removed[low.Peek()] -= 1;
                low.Dequeue();
            }
            while (removed.GetValueOrDefault(high.Peek()) > 0)
            {
                removed[high.Peek()] -= 1;
                high.Dequeue();
            }

            res[i - k + 1] = (k & 1) == 0 ?
                (low.Peek() + high.Peek()) / 2.0 :
                high.Peek();
        }
        return res;
    }

    public static double[] MedianSlidingWindow_DynamicMedian(int[] nums, int k)
    {
        int n = nums.Length;
        var res = new double[n - k + 1];
        var dm = new DynamicMedian();
        for (int i = 0; i < n; i++)
        {
            if (i < k)
            {
                dm.AddNum(nums[i]);
            }
            else
            {
                dm.AddAndDelete(nums[i], nums[i - k]);
            }

            if (i >= k - 1)
            {
                res[i - k + 1] = dm.GetMedian();
            }
        }
        return res;
    }
}
