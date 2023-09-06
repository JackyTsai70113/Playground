namespace playground.Queues;

public class MaxSlidingWindowClass
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-window-maximum
    /// </summary>
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        var linkedList = new LinkedList<int>();
        var res = new int[nums.Length + 1 - k];

        for (int i = 0; i < nums.Length; i++)
        {
            if (linkedList.Count > 0 && linkedList.First.Value < i - k + 1)
                linkedList.RemoveFirst();

            while (linkedList.Count > 0 && nums[linkedList.Last.Value] < nums[i])
                linkedList.RemoveLast();

            linkedList.AddLast(i);

            if (i >= k - 1)
                res[i + 1 - k] = nums[linkedList.First.Value];
        }

        return res;
    }
}
