namespace playground;

public class FrequencySort1636
{
    public static int[] FrequencySort(int[] nums)
    {
        Dictionary<int, int> counts = new();
        foreach (var num in nums)
        {
            counts[num] = counts.GetValueOrDefault(num) + 1;
        }

        Array.Sort(nums, (x, y) =>
        {
            if (counts[x] != counts[y])
                return counts[x] - counts[y];
            else
                return y - x;
        });
        return nums;
    }
}
