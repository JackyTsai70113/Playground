namespace playground_0900_0999;

public class _0962_MaxWidthRamp
{
    public static int MaxWidthRamp(int[] nums)
    {
        var stack = new Stack<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (stack.Count == 0 || nums[stack.Peek()] > nums[i])
                stack.Push(i);
        }
        var max = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && nums[stack.Peek()] <= nums[i])
            {
                max = Math.Max(max, i - stack.Pop());
            }
            if (stack.Count == 0)
                break;
        }
        return max;
    }
}
