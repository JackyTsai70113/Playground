namespace playground;

public class MaxSlidingWindow0239
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-window-maximum
    /// </summary>
    /// <remarks>
    /// #MonotonicQueue
    /// </remarks>
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        var linkedList = new LinkedList<int>();
        var res = new int[nums.Length - k + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            if (linkedList.Count > 0 && linkedList.First.Value <= i - k)
            {
                linkedList.RemoveFirst();
            }
            while (linkedList.Count > 0 && nums[linkedList.Last.Value] < nums[i])
            {
                linkedList.RemoveLast();
            }
            linkedList.AddLast(i);
            if (i - k + 1 >= 0)
            {
                res[i - k + 1] = nums[linkedList.First.Value];
            }
        }
        return res;
    }
}
