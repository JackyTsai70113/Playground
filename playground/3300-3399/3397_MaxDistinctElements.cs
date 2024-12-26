namespace playground._3300_3399;

public class _3397_MaxDistinctElements
{
    public static int MaxDistinctElements(int[] nums, int k)
    {
        if (nums.Length == 1) return 1;
        Array.Sort(nums);
        int min = nums[0] - k, max = nums[^1] + k;
        var set = new HashSet<int>();
        set.Add(min);
        set.Add(max);
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] - k > min + 1)
            {
                min = nums[i] - k;
            }
            else
            {
                min = Math.Min(nums[i] + k, min + 1);
            }
            set.Add(min);
        }
        return set.Count;
    }
}
