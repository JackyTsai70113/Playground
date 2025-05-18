namespace playground.LeetCode._3000_3999;

public class _3346_MaxFrequency
{
    public static int MaxFrequency(int[] nums, int k, int numOperations)
    {
        Array.Sort(nums);
        int n = nums.Length;
        int maxf = 0;

        var counts = new int[100001];
        foreach (var num in nums)
            counts[num]++;

        if (numOperations == 0)
            return counts.Max();

        // element in the array
        int left = 0, right = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] - nums[left] > k)
                left++;
            while (right < n && nums[right] - nums[i] <= k)
                right++;
            int curf = Math.Min(numOperations, right - left - counts[nums[i]]);
            maxf = Math.Max(maxf, curf + counts[nums[i]]);
        }

        // element not in the array
        left = 0;
        for (right = 0; right < nums.Length; right++)
        {
            while (nums[right] - nums[left] > k * 2)
                left++;
            var currentCount = nums[right] >= k ? counts[nums[right] - k] : 0;
            int curf = Math.Min(numOperations, right - left + 1 - currentCount);
            maxf = Math.Max(maxf, curf + currentCount);
        }
        return maxf;
    }
}
