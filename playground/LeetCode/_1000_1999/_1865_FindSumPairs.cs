namespace playground.LeetCode._1000_1999;

public class _1865_FindSumPairs
{

    private readonly int[] nums1;
    private readonly int[] nums2;
    private readonly Dictionary<int, int> nums2Freq;

    public _1865_FindSumPairs(int[] nums1, int[] nums2)
    {
        this.nums1 = nums1;
        this.nums2 = nums2;

        nums2Freq = new Dictionary<int, int>();
        foreach (int num in nums2)
        {
            nums2Freq[num] = nums2Freq.GetValueOrDefault(num, 0) + 1;
        }
    }

    public void Add(int index, int val)
    {
        int oldVal = nums2[index];
        nums2Freq[oldVal]--;
        if (nums2Freq[oldVal] == 0)
        {
            nums2Freq.Remove(oldVal);
        }

        nums2[index] += val;

        int newVal = nums2[index];
        nums2Freq[newVal] = nums2Freq.GetValueOrDefault(newVal, 0) + 1;
    }

    public int Count(int tot)
    {
        int pairCount = 0;
        foreach (int num1Val in nums1)
        {
            int requiredNum2Val = tot - num1Val;

            if (nums2Freq.ContainsKey(requiredNum2Val))
            {
                pairCount += nums2Freq[requiredNum2Val];
            }
        }
        return pairCount;
    }
}
