namespace playground.LeetCode._3000_3999;

public class _3326_MinOperations
{
    public static int MinOperations(int[] nums)
    {
        var res = 0;
        var divided = new Dictionary<int, int>();
        int GetDivided(int num)
        {
            if (divided.ContainsKey(num))
                return divided[num];
            int res = -1;
            for (int i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    res = i;
                    break;
                }
            }
            return divided[num] = res;
        }
        var stack = new Stack<int>();
        Stack<int> stack2;
        for (int i = 0; i < nums.Length; i++)
        {
            stack2 = new Stack<int>();
            int cur = nums[i];
            while (stack.Count > 0 && nums[stack.Peek()] > cur)
            {
                res++;
                int index = stack.Pop();
                nums[index] = GetDivided(nums[index]);
                if (nums[index] > cur)
                {
                    stack.Push(index);
                    continue;
                }
                cur = nums[index];
                if (cur == -1)
                    return -1;
                stack2.Push(index);
            }
            while (stack2.Count > 0)
            {
                stack.Push(stack2.Pop());
            }
            stack.Push(i);
        }
        return res;
    }
}
