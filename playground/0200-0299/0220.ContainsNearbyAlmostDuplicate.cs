namespace playground;

public class ContainsNearbyAlmostDuplicate0220
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate-iii
    /// </summary>
    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        var buckets = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int bucket = nums[i] / (valueDiff + 1);
            if (nums[i] < 0) bucket--;
            if (buckets.ContainsKey(bucket))
                return true;
            if (buckets.ContainsKey(bucket - 1) && nums[i] - buckets[bucket - 1] <= valueDiff)
                return true;
            if (buckets.ContainsKey(bucket + 1) && buckets[bucket + 1] - nums[i] <= valueDiff)
                return true;
            buckets[bucket] = nums[i];
            if (buckets.Count > indexDiff)
            {
                var key = nums[i - indexDiff] / (valueDiff + 1);
                buckets.Remove(key);
            }
        }
        return false;
    }
}
