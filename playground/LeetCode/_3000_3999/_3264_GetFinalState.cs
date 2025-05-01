namespace playground;

public class _3264_GetFinalState
{
    public static int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(i, nums[i] * 100 + i);
        }
        for (int i = 0; i < k; i++)
        {
            int idx = pq.Dequeue();
            nums[idx] *= multiplier;
            pq.Enqueue(idx, nums[idx] * 100 + idx);
        }
        return nums;
    }
}
