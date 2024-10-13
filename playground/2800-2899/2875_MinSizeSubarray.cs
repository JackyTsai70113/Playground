namespace playground._2800_2899;

public class _2875_MinSizeSubarray
{
    public static int MinSizeSubarray(int[] nums, int target)
    {
        long sum = 0;
        foreach (var num in nums)
            sum += num;
        long res = 0, target2 = target;
        if (target >= sum)
        {
            res += target / sum * nums.Length;
            target2 %= sum;
        }
        if (target2 == 0)
            return (int)res;
        long cur = 0;
        int min = nums.Length;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            cur += nums[r];
            while (cur >= target2)
            {
                if (cur == target2)
                {
                    min = Math.Min(min, r - l + 1);
                }
                cur -= nums[l];
                l++;
            }
        }
        cur = 0;
        int max = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            cur += nums[r];
            while (cur > sum - target2)
            {
                cur -= nums[l];
                l++;
            }
            if (cur == sum - target2)
            {
                max = Math.Max(max, r - l + 1);
            }
        }
        if (min == nums.Length && max == 0)
            return -1;
        return (int)res + Math.Min(min, nums.Length - max);
    }
}
