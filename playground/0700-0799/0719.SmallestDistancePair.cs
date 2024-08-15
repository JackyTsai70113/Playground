namespace playground;

public class SmallestDistancePair0719
{
    public static int SmallestDistancePair(int[] nums, int k)
    {
        Array.Sort(nums);
        int l = 0, r = nums[^1] - nums[0];
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (CountOfDist(nums, m) >= k)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }

    static int CountOfDist(int[] nums, int dist)
    {
        int count = 0;
        for (int l = 0, r = 1; r < nums.Length; r++)
        {
            while (l < r && nums[r] - nums[l] > dist)
            {
                l++;
            }
            count += r - l;
        }
        return count;
    }
}
