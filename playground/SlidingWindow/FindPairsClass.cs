namespace playground.SlidingWindow;

public class FindPairsClass
{
    public static int FindPairs(int[] nums, int k)
    {
        int n = nums.Length, res = 0;
        Array.Sort(nums);
        for (int l = 0, r = 0; r < n; ++l)
        {
            while (r <= l || r < n && nums[r] - nums[l] < k) r++;
            if (r < n && nums[r] - nums[l] == k) res++;
            while (l + 1 < n && nums[l] == nums[l + 1]) l++;
        }
        return res;
    }
}
